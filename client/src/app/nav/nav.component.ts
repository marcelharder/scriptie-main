import { Component, OnInit } from '@angular/core';
import { AuthService } from '../_services/auth.service';
import { ToastrService } from 'ngx-toastr';

@Component({
  selector: 'app-nav',
  templateUrl: './nav.component.html',
  styleUrls: ['./nav.component.css']
})
export class NavComponent implements OnInit {
  
  currentUserName = "";
  model: any = {};
  loginFailed = false;

  constructor(public auth: AuthService, private toast:ToastrService) { }

  ngOnInit() {
    this.auth.currentUser$.subscribe((next)=>{
      
      this.currentUserName = next.username})
  }

  logOut() {
    this.toast.info("Logged out ...");
    this.auth.logOut();
  }

  login() {
    
    this.auth.login(this.model).subscribe({
        next: (next) => { 
          this.toast.info("Logged in successfully");
          this.loginFailed = false; },
        error: (e) => {
          this.toast.info(e.error);
          console.error(e);
          this.loginFailed = true;
        },
        complete: () => console.info('complete')
      });

  }
}
