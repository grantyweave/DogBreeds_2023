import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { BreedListComponent } from './breed/breed-list/breed-list.component';
import { CommonModule } from '@angular/common';
import { ExpenseEntryComponent } from './expense-entry/expense-entry.component';
import { ExpenseEntryListComponent } from './expense-entry-list/expense-entry-list.component';
import { LoginComponent } from './login/login.component';
import { LogoutComponent } from './logout/logout.component';

import { ExpenseGuard } from './expense.guard';

const routes: Routes = [
  { path: 'breed-list', component: BreedListComponent },
  { path: 'login', component: LoginComponent },
  { path: 'logout', component: LogoutComponent },
  { path: 'expenses', component: ExpenseEntryListComponent, canActivate: [ExpenseGuard] },
  { path: 'expenses/detail/:id', component: ExpenseEntryComponent, canActivate: [ExpenseGuard] },
  { path: '', redirectTo: 'expenses', pathMatch: 'full' }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }