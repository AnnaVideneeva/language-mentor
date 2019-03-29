import { ExerciseModel } from './exercise-model';

export class ExaminationModel {
    public ExaminationId: number;
    public Description: string;
    public ExaminationTypeId: number;
    public Exercises: ExerciseModel[];
}