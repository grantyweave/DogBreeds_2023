import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { BreedListComponent } from './breed/breed-list/breed-list.component';
import { CommonModule } from '@angular/common';

const routes: Routes = [
  {path: 'breed-list', component : BreedListComponent},
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }