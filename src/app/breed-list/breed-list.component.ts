import { AfterViewInit, Component, Input } from '@angular/core';
import { ApiService } from '../api.service';
import { IBreeds } from '../interface/breeds';

@Component({
  selector: 'app-breed-list, child-component',
  templateUrl: './breed-list.component.html',
  styleUrls: ['./breed-list.component.css']
})
export class BreedListComponent{
  @Input() currentUser: any;
  

  constructor(private api: ApiService) { }
  dogBreeds: any;
  
  
  ngOnInit(): void {
    this.getAllDogBreeds();
  }

  getAllDogBreeds() {
    this.api.getBreeds().subscribe(
      (response) => {
        this.dogBreeds = response;
      });
  }

  addFave(breedToUpdate: IBreeds){
    console.log("current User", this.currentUser, "incoming breed object", breedToUpdate)
    let userId = this.currentUser.id;
    console.log("created userId in favorite", userId, "currentuserId=", this.currentUser.id)
    breedToUpdate.userId = userId
    console.log(breedToUpdate.userId, this.currentUser)
    this.api.addFave(breedToUpdate).subscribe({
      next: (response: any) => {
        console.log(response)
      return response;
      }
      });
  }
}