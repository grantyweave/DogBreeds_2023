import { Component } from '@angular/core';
import { DogRepositoryService } from 'src/app/dog-repository.service';

@Component({
  selector: 'app-breed-list',
  templateUrl: './breed-list.component.html',
  styleUrls: ['./breed-list.component.css']
})
export class BreedListComponent {
  title = 'DogBreed_AngApp';


  constructor(private repositoryService: DogRepositoryService) { }
  dogBreeds: any;

  ngOnInit(): void {
    this.getAllDogBreeds();
  }
  getAllDogBreeds() {
    this.repositoryService.getDogBreeds().subscribe(
      (response) => {
        this.dogBreeds = response;
        // add alert
        // do calculation
      });
  }
}