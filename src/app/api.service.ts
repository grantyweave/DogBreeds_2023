import { Injectable } from '@angular/core';
import { IUser } from './interfaces/user';
import { HttpClient, HttpHeaders } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class ApiService {
  private breedUri = 'https://dog-breeds2.p.rapidapi.com/dog_breeds';
  private userApi ='https://localhost:7078/api/Users';
  private faveApi ='https://localhost:7078/api/FavoriteBreeds';

  constructor(private http: HttpClient){}

  addUser(newUser: IUser){

   const linkString = (this.userApi+"/add?firstName="+newUser.firstName+"&lastName="+newUser.lastName+"&email="+newUser.email+"&password="+newUser.password)
    console.log("user api link created",{linkString})
   return linkString
   
  }



  getBreeds(){

    const headers = new HttpHeaders()
    .set('Content-Type', 'application/json')
    .set('X-RapidAPI-Host', 'dog-breeds2.p.rapidapi.com')
    .set('X-RapidAPI-Key', `0af66338bfmshdc0ab0c7e84ed2ap1db3a7jsncc8b1aa9b0e5`);
    const result = this.http.get(this.breedUri,{headers})

    return result
  }
}
