import { Component, ElementRef, ViewChild } from '@angular/core';
import { ApiService } from 'src/app/api.service';

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
