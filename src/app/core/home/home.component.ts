import { Component, ElementRef, ViewChild } from '@angular/core';
import { ApiService } from 'src/app/api.service';
import { IUser } from 'src/app/interfaces/user';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent {

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

  @ViewChild('name') nameKey!: ElementRef;

  startQuiz(){
    localStorage.setItem("name",this.nameKey.nativeElement.value);
  }
  
}
