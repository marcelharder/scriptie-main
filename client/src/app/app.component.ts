import { HttpClient } from '@angular/common/http';
import { Component, OnChanges, OnInit } from '@angular/core';
import { AuthService } from './_services/auth.service';
import { user } from './_models/user';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
  title = 'client';
  constructor(
  private http: HttpClient, 
  private accountService: AuthService
  ) {
     
}


  ngOnInit(): void {
    this.setCurrentUser();
  }
  
  setCurrentUser(){
    const userstring:user = JSON.parse(localStorage.getItem('user'));
    if (!!userstring) {this.accountService.setCurrentUser(userstring);}
    else{this.accountService.setCurrentUser(null)}
    
  }

}
