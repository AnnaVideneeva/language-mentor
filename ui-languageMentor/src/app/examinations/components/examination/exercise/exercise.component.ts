import { Component, Input, EventEmitter, Output } from '@angular/core';

import { ExerciseModel } from '../../../../../app/examinations/shared/models/exercise-model';
import { SelectedAnswerModel } from '../models/selected-answer-model';

@Component({
  selector: 'app-exercise',
  templateUrl: './exercise.component.html',
  styleUrls: ['./exercise.component.scss']
})
export class ExerciseComponent {

  @Input() exercise: ExerciseModel;
  @Output() selectedAnswerEvent = new EventEmitter<SelectedAnswerModel>();

  private addSelectedAnswer(selectedAnswer: SelectedAnswerModel): void {
    selectedAnswer.ExerciseId = this.exercise.ExerciseId;
    this.selectedAnswerEvent.emit(selectedAnswer);
  }
}
