import { Component } from '@angular/core';
import { NgForm } from '@angular/forms';
import { IUser } from '../interface/user';

@Component({
  selector: 'app-user',
  templateUrl: './user.component.html',
  styleUrls: ['./user.component.css']
})
export class UserComponent {
firstName: string = ""
lastName?: string = ""
email: string = ""
password: string = ""

addNewUser(form: NgForm) {
  let newUser: IUser = {
   id: -1,
   firstName: form.form.value.firstName,
   lastName: form.form.value.lastName,
   email: form.form.value.email,
   password: form.form.value.password
  };
}
}
