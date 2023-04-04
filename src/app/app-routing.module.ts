import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { CommonModule } from '@angular/common';
import { BreedListComponent } from './breed/breed-list/breed-list.component';
import { HomeComponent } from './core/home/home.component';
import { UserComponent } from './user/user/user.component';
import { QuizComponent } from './quiz/quiz.component';

const routes: Routes = [
  {path:"home", component: HomeComponent},
  { path: 'breed-list',component: BreedListComponent},
  { path: "user", component: UserComponent},
  { path: "quiz", component: QuizComponent}
  
  

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
