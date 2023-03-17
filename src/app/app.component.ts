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

  constructor(private http: HttpClient) { }

  title = 'DogBreed_AngApp';

  // ngOnInit() {
  //   //API Call
  //   let headers = new HttpHeaders({
  //     'x-rapidapi-host': 'dog-breeds2.p.rapidapi.com',
  //     'x-rapidapi-key': 'fa9f7972a9msh92b06a00e5027a2p139140jsnc1f3af45cbca'
  //   })
  //   this.http.get<any>('https://dog-breeds2.p.rapidapi.com/dog_breeds', { 'headers': headers })
  //     .subscribe(data => { console.log(data); });
  // }

  ngOnInit() {
    //API Call
    string apiUri = $"https://dog-breeds2.p.rapidapi.com/dog_breeds";
      var apiTask = apiUri.WithHeaders(new
      {
        x_rapidapi_host = "dog-breeds2.p.rapidapi.com",
        x_rapidapi_key = "fa9f7972a9msh92b06a00e5027a2p139140jsnc1f3af45cbca"

      }).GetJsonAsync<List<DogBreed>>();
      apiTask.Wait();
      List<DogBreed> dogBreeds = apiTask.Result;
      return (dogBreeds);
  }
}