import { Injectable } from '@angular/core';
import { HttpClient,HttpHeaders, HttpParams } from '@angular/common/http';
import { IUser } from './interface/user';

@Injectable({
  providedIn: 'root'
})
export class ApiService {
  private breedUri = 'https://dog-breeds2.p.rapidapi.com/dog_breeds';
  private userApi ='https://localhost:7078/api/Users';
  private faveApi ='https://localhost:7078/api/FavoriteBreeds';

  constructor(private http: HttpClient){}

  addUser(newUser: IUser){
  //  const queryParams = new HttpParams()
  //  queryParams.append('firstName', newUser.firstName)
  //  queryParams.append('lastName', newUser.lastName)
  //  queryParams.append('email', newUser.email)
  //  queryParams.append('pass', newUser.password)
   const linkString = (this.userApi+"/add?firstName="+newUser.firstName+"&lastName="+newUser.lastName+"&email="+newUser.email+"&password="+newUser.password)
  //  const result = this.http.get(linkString);
  //  /add?firstName=l&lastName=ll&email=l.l.mail&password=pass
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