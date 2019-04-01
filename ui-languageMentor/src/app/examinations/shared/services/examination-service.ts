import { Injectable } from '@angular/core';
import { Environment } from '../../../../environments/environment';
import { HttpClient} from '@angular/common/http';
import { Observable } from 'rxjs';
import { ExaminationModel } from '../models/examination-model';
import { ExaminationTypes } from '../../../shared/constants/examination-types';
import { LevelModel } from '../models/level-model';

@Injectable({
    providedIn: 'root'
  })
export class ExaminationService {
    private url = Environment.apiUrl + 'api/examinations';

    constructor(
        private http: HttpClient
        ) 
    {}

    public getExamination(examinationType: ExaminationTypes): Observable<ExaminationModel> {
        return this.http.get<ExaminationModel>(`${this.url}?examinationType=${examinationType}`);
    }

    public getResult(examination: ExaminationModel): Observable<LevelModel> {
        return this.http.post<LevelModel>(`${this.url}`, examination);
    }
}