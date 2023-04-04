
import { Component, ElementRef, ViewChild } from '@angular/core';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent {
 

  @ViewChild('name') nameKey!: ElementRef;

  startQuiz(){
    localStorage.setItem("name",this.nameKey.nativeElement.value);
  }
 
}
