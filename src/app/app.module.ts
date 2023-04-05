import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule } from '@angular/common/http';
import { AppComponent } from './app.component';
import { BreedModule } from './breed/breed.module';
import { AppRoutingModule } from './app-routing.module';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { QuizComponent } from './quiz/quiz.component';
import { ChangeBgDirective } from './change-bg.directive';
import { CommonModule } from '@angular/common';
import { Ng2SearchPipeModule } from 'ng2-search-filter';
import { UserModule } from './user/user.module';

@NgModule({
  declarations: [
    AppComponent,
    QuizComponent,
    ChangeBgDirective,
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,

    HttpClientModule,
    FormsModule,
    Ng2SearchPipeModule,
    CommonModule,
    BreedModule,
    ReactiveFormsModule,
    CoreModule,
    UserModule
  ],
  providers: [
    
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
