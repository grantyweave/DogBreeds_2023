import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { BreedListComponent } from './breed-list.component';
import { AppRoutingModule } from '../../app-routing.module';
import { BrowserModule } from '@angular/platform-browser';
import { Ng2SearchPipeModule } from 'ng2-search-filter';
import { AppComponent } from '../../app.component';
import { FormsModule } from '@angular/forms';
import { RouterModule } from '@angular/router';
import { ApiService } from '../../api.service';

@NgModule({
  declarations: [
    BreedListComponent,
    AppComponent
  ],
  imports: [
    CommonModule,
    NgModule,
    AppRoutingModule,
    BrowserModule,
    Ng2SearchPipeModule,
    FormsModule,
    RouterModule,
    ApiService
  ],
  exports: [
    BreedListComponent
  ],
  bootstrap: [AppComponent]
})
export class BreedModule { }
