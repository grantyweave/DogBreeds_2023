import { Component } from '@angular/core';
import { ApiService } from './api.service';
import { IUser } from './interface/user';
import { ITeam } from './interface/team';

 

@Component({
  selector: 'app-root, parent-component',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title='DogBreed_AngApp'
  //setting up for the contact us
    
  rizzo: ITeam ={
    firstName: "John",
    lastName: "Rizzo",
    phone: "(734)772-5404",
    email: "JRizzo1390@gmail.com",
    linkedin:"https://www.linkedin.com/in/jrizzo88/"
  }
  testOne: ITeam ={
    firstName: "geary",
    lastName: "testguy",
    phone: "(123)555-1234",
     email: "fakeEmail@gmail.com",
    linkedin:"im not gonna try and fake type a linkedin link"
  }
  yourName: ITeam ={
    firstName: "",
    lastName: "",
    phone: "",
    email: "",
    linkedin:""
  }
  anotherName: ITeam ={
    firstName: "",
    lastName: "",
    phone: "",
    email: "",
    linkedin:""
  }

  userIsNotLoggedOn = true;
  userIsLoggedOn = false;
  addform: any;
  createform: any;
  loginForm: any;
  currentUser: IUser | undefined;
  userIsAdmin = false;

  constructor(private api: ApiService){}

  CreateUser(){
      this.createform = document.getElementById('userCreateForm');
      const formData = new FormData(this.createform);

      let newUser: IUser = 
      {
      FirstName: formData.get("firstName") as string,
      LastName: formData.get("lastName") as string,
      Email: formData.get("createEmail") as string,
      Password: formData.get("createPsw") as string
      };
      console.log("user object being created check", {newUser})

      this.userIsNotLoggedOn = false;
      this.userIsLoggedOn = true;
        

      console.log("userIsLoggedOn=",this.userIsLoggedOn,"userIsNotLoggedOn=", this.userIsNotLoggedOn, "current user",this.currentUser)
      
      this.api.loginUser(newUser).subscribe({
        next: (response: any) => {
            this.currentUser=response;
            console.log("current user after create api call", this.currentUser)   
            return response;
        }
      })
  }
    loginUser(){
      this.loginForm = document.getElementById('loginForm');
      const formData = new FormData(this.loginForm);
      
      let loginUser: IUser = 
      {
        FirstName: "null",
        LastName: "null",
        Email: formData.get("loginEmail") as string,
        Password: formData.get("loginPsw") as string
      };

      this.userIsNotLoggedOn = false;
      this.userIsLoggedOn = true;
      console.log("userIsNotLoggedIn=",this.userIsNotLoggedOn,"userIsLoggedIn=", this.userIsLoggedOn, "user with null first and last names to get user from database", loginUser);

      this.api.loginUser(loginUser).subscribe({
        next: (response: any) => {
          this.currentUser=response;
          console.log("api login call response user object" , response, "current user object", this.currentUser)
          return response;
        }
      })
      
    }
      
    showCreateModal(){
      console.log("modal is triggered")
      document.getElementById("userCreateModal")!.style.display = "block"
    }
    hideCreateModal(){
      document.getElementById("userCreateModal")!.style.display = "none"
    }
    showLoginModal(){
      console.log("modal is triggered")
      document.getElementById("loginModal")!.style.display = "block"
    }
    hideLoginModal(){
      document.getElementById("loginModal")!.style.display = "none"
    }
    showUserpageModal(){
      console.log("modal is triggered")
      document.getElementById("userModal")!.style.display = "block"
    }
    hideUserpageModal(){
      document.getElementById("userModal")!.style.display = "none"
    }
}
