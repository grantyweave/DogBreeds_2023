import { Component } from '@angular/core';
import { NgForm } from '@angular/forms';
import { DogRepositoryService } from './dog-repository.service';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { IBreeds } from './interface/breeds';
import { AuthService } from './auth.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'DogBreed_AngApp';
  isUserLoggedIn = false;

  constructor(private authService: AuthService) {}

  ngOnInit() {
    let storeData = localStorage.getItem("isUserLoggedIn");
    console.log("StoreData: " + storeData);

    if( storeData != null && storeData == "true")
       this.isUserLoggedIn = true;
    else


       this.isUserLoggedIn = false;

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
  // searchByDogBreed(breed:IBreeds) {
  //   this.repositoryService.searchAllDogBreeds(breed).subscribe(
  //     (response) => {
  //       this.dogBreeds = response;
  // }
  // )
}
