import { Component, ElementRef, Input, ViewChild } from '@angular/core';
import { NgForm } from '@angular/forms';
import { ApiService } from 'src/app/api.service';
import { IBreeds } from 'src/app/interfaces/breed';

@Component({
  selector: 'app-breed-list',
  templateUrl: './breed-list.component.html',
  styleUrls: ['./breed-list.component.css']
})
export class BreedListComponent {

  @Input() currentUser: any;
  
  constructor(private api: ApiService) { }
  dogBreeds?: any;
  searchText?: any;
  foundBreeds: boolean = false;
  breedSearch: IBreeds[] | undefined;

  ngOnInit(): void {
    this.getAllDogBreeds();
  }

  getAllDogBreeds() {
    this.api.getBreeds().subscribe(
      (response) => {
        this.dogBreeds = response;
      });
  }

  searchByDogBreed(form: NgForm) {
    this.searchText = form.form.value.searchText;
    this.api.searchAllDogBreeds(this.searchText).subscribe(
      (response) => {
        this.dogBreeds = response;
        this.foundBreeds = true;
      }
    )
    form.resetForm();
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
