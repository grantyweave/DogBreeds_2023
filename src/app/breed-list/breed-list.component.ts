import { Component } from '@angular/core';
// import { DogRepositoryService } from 'src/app/dog-repository.service';
import { ApiService } from '../api.service';

@Component({
  selector: 'app-breed-list',
  templateUrl: './breed-list.component.html',
  styleUrls: ['./breed-list.component.css']
})
export class BreedListComponent {
  title = 'DogBreed_AngApp';
  
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


}