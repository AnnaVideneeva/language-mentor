import { AnswerModel } from './answer-model';

export class PointModel {
    public PointId: number;
    public PointText: string;
    public AnswerChoices: AnswerModel[];
    public SelectedAnswers: AnswerModel[];
    public IsMultipleChoices: boolean;
}