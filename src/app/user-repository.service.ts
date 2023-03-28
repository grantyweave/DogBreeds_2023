import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { IUser } from './interface/user';

@Injectable({
  providedIn: 'root'
})
export class UserRepositoryService {
  private apiUri='https://localhost:7078/api/user'
  constructor(private http:HttpClient) { }
  addUser(user: IUser){
    return this.http.post(`${this.apiUri}/add`,user)
  }
}
