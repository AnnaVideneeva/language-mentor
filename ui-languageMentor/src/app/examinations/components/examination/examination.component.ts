import { Component, OnInit, Input } from '@angular/core';

import { ExaminationModel } from '../../shared/models/examination-model';
import { ExaminationTypes } from '../../../shared/constants/examination-types';
import { ExaminationService } from '../../shared/services/examination-service';
import { SelectedAnswerModel } from './models/selected-answer-model';
import { LevelModel } from '../../shared/models/level-model';

@Component({
  selector: 'app-examination',
  templateUrl: './examination.component.html',
  styleUrls: ['./examination.component.scss']
})
export class ExaminationComponent implements OnInit {
  private examination: ExaminationModel;
  private level: LevelModel;
  private isFilledPoints = false;
  private isLevelLoaded = false;

  @Input() examinationType: ExaminationTypes;

  constructor(
    private readonly examinationService: ExaminationService
  ) { }

  ngOnInit() {
    this.examinationService.getExamination(this.examinationType)
      .subscribe(examination => this.examination = examination);
  }

  private addSelectedAnswer(selectedAnswer: SelectedAnswerModel): void {
    const point = this.examination
        .Exercises.find(ex => ex.ExerciseId === selectedAnswer.ExerciseId)
        .Points.find(p => p.PointId === selectedAnswer.PointId);

    if ((point.IsMultipleChoices && point.SelectedAnswers.length < point.AnswerChoices.length)
      || (!point.IsMultipleChoices && point.SelectedAnswers.length === 0)) {
        point.SelectedAnswers.push({ AnswerId: selectedAnswer.AnswerId});
    }
  }

  private getResult(): void {
    this.isFilledPoints = true;
    this.examination
        .Exercises.forEach(exercise => {
          exercise.Points.forEach(point => {
            if (point.SelectedAnswers.length === 0) {
              this.isFilledPoints = false;
            }
          });
        });

    if (this.isFilledPoints) {
      this.examinationService.getResult(this.examination)
        .subscribe(level => {
          this.isLevelLoaded = true;
          this.level = level;
        });
    }
  }
}
