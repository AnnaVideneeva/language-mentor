import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { HttpClientModule } from '@angular/common/http';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HomeComponent } from './home/home.component';
import { DiagnosticExaminationComponent } from './examinations/diagnostic-examination/diagnostic-examination.component';
import { ExaminationComponent } from './examinations/components/examination/examination.component';
import { ExaminationService } from './examinations/shared/services/examination-service';
import { ExerciseComponent } from './examinations/components/examination/exercise/exercise.component';
import { PointComponent } from './examinations/components/examination/point/point.component';

@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    DiagnosticExaminationComponent,
    ExaminationComponent,
    ExerciseComponent,
    PointComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule
  ],
  providers: [
    ExaminationService
  ],
  bootstrap: [
    AppComponent
  ]
})
export class AppModule { }
