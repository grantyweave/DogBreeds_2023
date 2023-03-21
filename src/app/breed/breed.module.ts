import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { BreedListComponent } from './breed-list/breed-list.component';

@NgModule({
  declarations: [
    BreedListComponent
  ],
  imports: [
    CommonModule
  ],
  exports: [
    BreedListComponent
  ]
})
export class BreedModule { }
