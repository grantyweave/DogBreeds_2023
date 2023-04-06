import { AfterViewInit, Component, Input } from '@angular/core';
import { NgForm } from '@angular/forms';


@Component({
  selector: 'app-user',
  templateUrl: './user.component.html',
  styleUrls: ['./user.component.css']
})
export class UserComponent implements AfterViewInit {

  @Input() currentUser: any;
  faveBreeds: any;
  
  
  constructor(){}

  ngAfterViewInit(): void {
    this.faveBreeds = this.currentUser.Favorites;
  }

}
