
import { Component } from '@angular/core';
import { ApiService } from './api.service';
import { IUser } from './interface/user';
import { NgForm } from '@angular/forms';
// import { DogRepositoryService } from './dog-repository.service';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { IBreeds } from './interface/breeds';
import { last } from 'rxjs';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
    title = 'DogBreed_AngApp';
    isUserNotLoggedOn = true;
    addform: any;
    
    
    
    
    

    constructor(private api: ApiService){}

    addNewUser(){
        this.addform = document.getElementById('loginForm');
        const formData = new FormData(this.addform);

      let newUser: IUser = {
       
        firstName: formData.get("firstName") as string,
        lastName: formData.get("lastName") as string,
        email: formData.get("email") as string,
        password: formData.get("psw") as string
       };
          console.log("user object being created check", {newUser})
          this.api.addUser(newUser);

      }
      
      //   const formData = new FormData(addForm);

      //   const firstName = formData.get("firstName") as string
      //   const lastName = formData.get("lastName") as string
      //   const email = formData.get("email") as string
      //   const pass = formData.get("psw") as string
      // console.log({firstName},{lastName},{email},{pass})
      //   this.api.addUser(firstName,lastName,email,pass)
      
      
      
    


    showLogModal(){
      console.log("modal is triggered")
      document.getElementById("userModal")!.style.display = "block"
    }
    hideModal(){
      document.getElementById("userModal")!.style.display = "none"
    }
}
  // constructor(private repositoryService: DogRepositoryService) { }
  // dogBreeds: any;

  // ngOnInit(): void {
  //   this.getAllDogBreeds();
  // }

  // getAllDogBreeds() {
  //   this.repositoryService.getDogBreeds().subscribe(
  //     (response) => {
  //       this.dogBreeds = response;
  //       // add alert
  //       // do calculation
  //     });
  // }
  // searchByDogBreed(breed:IBreeds) {
  //   this.repositoryService.searchAllDogBreeds(breed).subscribe(
  //     (response) => {
  //       this.dogBreeds = response;
  // }
  // )
