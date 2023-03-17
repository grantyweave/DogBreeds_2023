import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { IBreeds } from './interface/breeds';

@Injectable({
  providedIn: 'root'
})

export class DogRepositoryService  {

  constructor(private http: HttpClient) { }


  apiUri: string = 'https://localhost:7078/api/DogBreed/breed'


  getDogBreeds() {
    return this.http.get(this.apiUri)
  }
}