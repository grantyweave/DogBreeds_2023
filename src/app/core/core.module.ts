
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { HomeComponent } from './home/home.component';
import { BreedModule } from '../breed/breed.module';
import { UserModule } from '../user/user.module';



@NgModule({
  declarations: [
    HomeComponent
  ],
  imports: [
    CommonModule,
    BreedModule,
    UserModule
  ],
  exports: [
    HomeComponent
  ]
})
export class CoreModule { }