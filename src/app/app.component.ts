import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { DogRepositoryService } from './dog-repository.service';
import { HttpClient, HttpHeaders } from '@angular/common/http';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {

  totalAngularPackages: any;

  title = 'DogBreed_AngApp';

  constructor(private http: HttpClient) { }


  ngOnInit() {
    let headers = new HttpHeaders({
      'x-rapidapi-host': 'dog-breeds2.p.rapidapi.com',
      'x-rapidapi-key': 'fa9f7972a9msh92b06a00e5027a2p139140jsnc1f3af45cbca'
    });
    this.http.get<any>('https://dog-breeds2.p.rapidapi.com/dog_breeds', { 'headers': headers })
      .subscribe(data => { this.totalAngularPackages = data.total; });
  }


}










  // constructor(private repositoryService: DogRepositoryService) { }
  
  // ngOnInit(): void {
  //   this.getBreeds();
  // }

  // getBreeds() {
  //   this.repositoryService.getDogBreeds().subscribe(
  //     (response) => {
  //       this.boardGames = response;
  //       // add alert
  //       // do calculation
  //     });
