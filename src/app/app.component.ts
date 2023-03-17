import { Component } from '@angular/core';
import { NgForm } from '@angular/forms';
import { DogRepositoryService } from './dog-repository.service';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { IBreeds } from './interface/breeds';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
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