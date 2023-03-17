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

//ngOnInit() {
  //   //API Call
  //   let headers = new HttpHeaders({
  //     'x-rapidapi-host': 'dog-breeds2.p.rapidapi.com',
  //     'x-rapidapi-key': 'fa9f7972a9msh92b06a00e5027a2p139140jsnc1f3af45cbca'
  //   })
  //   this.http.get<any>('https://dog-breeds2.p.rapidapi.com/dog_breeds', { 'headers': headers })
  //     .subscribe(data => { console.log(data); });