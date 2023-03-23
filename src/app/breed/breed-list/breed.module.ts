import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { BreedListComponent } from '../breed-list/breed-list.component';
import { AppRoutingModule } from '../../app-routing.module';

@NgModule({
  declarations: [
    BreedListComponent
  ],
  imports: [
    CommonModule,
    AppRoutingModule
  ],
  exports: [
    BreedListComponent
  ]
})
export class BreedModule { }
