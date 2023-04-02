import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { CommonModule } from '@angular/common';
import { BreedListComponent } from './breed/breed-list/breed-list.component';
import { QuizComponent } from './quiz/quiz.component';
import { HomeComponent } from './core/home/home.component';

const routes: Routes = [
  {path:"", redirectTo: "home",pathMatch:"full"},
  {path:"home", component: HomeComponent},
  { path: 'breed-list',component: BreedListComponent},
  { path: 'quiz', component: QuizComponent}
  
  

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
