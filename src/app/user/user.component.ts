import { AfterViewInit, Component , Input} from '@angular/core';
import { IUser } from '../interface/user';


@Component({
  selector: 'app-user,child-component',
  templateUrl: './user.component.html',
  styleUrls: ['./user.component.css']
})
export class UserComponent implements AfterViewInit{
  @Input() currentUser: any;
  faveBreeds: any;
  
  
  constructor(){}

  ngAfterViewInit(): void {
    this.faveBreeds = this.currentUser.Favorites;
  }

  


}
