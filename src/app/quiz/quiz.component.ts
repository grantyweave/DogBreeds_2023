import { Component, Input } from '@angular/core';
import { QuizService } from '../quiz.service';

@Component({
  selector: 'app-quiz',
  templateUrl: './quiz.component.html',
  styleUrls: ['./quiz.component.css']
})
export class QuizComponent {

  @Input() currentUser: any;

  public name: string="";
  public questionList: any = [];
  public currentQuestion: number = 0;
  public points: number=0;
  correctAnswer:number =0;
  inCorrectAnswer:number =0;
  progress:string="0";
  isQuizCompleted: boolean = false;

  constructor(private quizService: QuizService) {}

  ngOnInit(): void {
    this.getAllQuestions();
  }

  getAllQuestions() {
    this.quizService.getQuestionJson()
    .subscribe(response=>{
      this.questionList = response.questions;
    })
  }

  nextQuestion(){
    this.currentQuestion++;
  }

  previousQuestion() {
    this.currentQuestion--;
  }

  answer(currentQno:number,option:any){

    if(currentQno === this.questionList.length){
      this.isQuizCompleted = true;
    }
    if(option.correct){
      this.points+= 10;
      this.correctAnswer++;
      setTimeout(() => {
        this.currentQuestion++;
        this.getProgressPercent();
      }, 1000);
      
    } else {
      setTimeout(() => {
        this.currentQuestion++;
        this.inCorrectAnswer++;
        this.getProgressPercent();
      }, 1000);
      this.points-= 10;
    }
  }

  getProgressPercent(){
    this.progress = ((this.currentQuestion/this.questionList.length)*100).toString();
    return this.progress;
  }

}
