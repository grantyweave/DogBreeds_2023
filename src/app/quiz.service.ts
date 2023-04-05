import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class QuizService {

  constructor(private http : HttpClient) { }

  getQuestionJson(){
    return this.http.get<any>("assets/question.json");
  }
  
}
