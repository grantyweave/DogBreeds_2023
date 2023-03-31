import { Component } from '@angular/core';
import { NgForm } from '@angular/forms';
import { ApiService } from 'src/app/api.service';
import { DogRepositoryService } from 'src/app/dog-repository.service';
import { IBreeds } from 'src/app/interface/breeds';


@Component({
  selector: 'app-breed-list',
  templateUrl: './breed-list.component.html',
  styleUrls: ['./breed-list.component.css']
})
export class BreedListComponent {
  title = 'DogBreed_AngApp';


  constructor(private repositoryService: DogRepositoryService, private api: ApiService) { }
  dogBreeds?: any;
  searchText?: any;
  foundBreeds: boolean = false;
  breedSearch: IBreeds | undefined;

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
    this.repositoryService.searchAllDogBreeds(this.searchText).subscribe(
      (response) => {
        this.dogBreeds = response;
        this.foundBreeds = true;
      }
    )
    form.resetForm();
  }
}