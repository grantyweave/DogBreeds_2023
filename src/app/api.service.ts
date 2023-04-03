import { Injectable } from '@angular/core';
import { HttpClient,HttpHeaders, HttpParams } from '@angular/common/http';
import { IUser } from './interface/user';
import { IBreeds } from './interface/breeds';

@Injectable({
  providedIn: 'root'
})
export class ApiService {

  constructor(private http: HttpClient){}
  
  //breed related api methods

  private breedUri = 'https://dog-breeds2.p.rapidapi.com/dog_breeds';

  getBreeds(){
    const headers = new HttpHeaders()
    .set('Content-Type', 'application/json')
    .set('X-RapidAPI-Host', 'dog-breeds2.p.rapidapi.com')
    .set('X-RapidAPI-Key', `0af66338bfmshdc0ab0c7e84ed2ap1db3a7jsncc8b1aa9b0e5`);
    const result = this.http.get(this.breedUri,{headers})
  
    return result
  }

  //user related api methods

  private userApi ='https://localhost:7078/api/Users';
  
  loginUser(newUser: IUser){
   return this.http.post(this.userApi +"/login", newUser)
  }

  getUserById(userId: number){
    return this.http.get(this.userApi +"/user/" + userId)
  }

  //favorite related api methods
  private faveApi ='https://localhost:7078/favorites';

  addFave(newFave: IBreeds){
    return this.http.post(this.faveApi +"/add", newFave)
  }

  

  //member api methods
  private memberApi ='https://localhost:7078/api/Member'
}