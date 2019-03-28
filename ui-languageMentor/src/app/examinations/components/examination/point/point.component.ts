import { Component, Input, Output, EventEmitter } from '@angular/core';

import { PointModel } from '../../../../../app/examinations/shared/models/point-model';
import { SelectedAnswerModel } from '../models/selected-answer-model';

@Component({
  selector: 'app-point',
  templateUrl: './point.component.html',
  styleUrls: ['./point.component.scss']
})
export class PointComponent {
  
  @Input() point: PointModel;
  @Output() selectedAnswerEvent = new EventEmitter<SelectedAnswerModel>();
  
  private addSelectedAnswer(pointId: number, answerId: number): void {
    this.selectedAnswerEvent.emit({ PointId: pointId, AnswerId: answerId });
  }
}
