import { Component } from '@angular/core';
import { DogRepositoryService } from '../dog-repository.service';
import { IBreeds } from '../interface/breeds';

@Component({
  selector: 'app-breed-search',
  templateUrl: './breed-search.component.html',
  styleUrls: ['./breed-search.component.css']
})
export class BreedSearchComponent {
  
  constructor(private repositoryService: DogRepositoryService) { }
  dogBreeds: any;
  searchText: string | undefined;

  searchByDogBreed(breed: IBreeds) {
    this.repositoryService.searchAllDogBreeds(breed).subscribe(
      (response) => {
        this.dogBreeds = response;
      }
    )
  }
}
