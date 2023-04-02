import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { BreedListComponent } from './breed-list/breed-list.component';
import { BreedSearchComponent } from './breed-search/breed-search.component';
import { AppRoutingModule } from '../app-routing.module';



@NgModule({
  declarations: [
    BreedListComponent,
    BreedSearchComponent
  ],
  imports: [
    CommonModule,
    AppRoutingModule
  ]
})
export class BreedModule { }
