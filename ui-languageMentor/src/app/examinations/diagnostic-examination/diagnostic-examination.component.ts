import { Component, OnInit } from '@angular/core';
import { ExaminationTypes } from 'src/app/shared/constants/examination-types';

@Component({
  selector: 'app-diagnostic-examination',
  templateUrl: './diagnostic-examination.component.html'
})
export class DiagnosticExaminationComponent implements OnInit { 
    public examinationType: ExaminationTypes;

    ngOnInit() {
      this.examinationType = ExaminationTypes.DiagnosticExamination;
    }
}
