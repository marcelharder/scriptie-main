import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

import { JwtHelperService } from '@auth0/angular-jwt';
import { BehaviorSubject, ReplaySubject, map } from 'rxjs';
import { environment } from 'src/environments/environment';
import { user } from '../_models/user';

@Injectable()
export class AuthService {
    baseUrl = environment.apiUrl;
    jwtHelper = new JwtHelperService();
  decodedToken: any;

constructor(private http: HttpClient) { }

private currentUserNameSource = new ReplaySubject<user>(1);
currentUser$ = this.currentUserNameSource.asObservable();
setCurrentUser(test: user){this.currentUserNameSource.next(test)}

logOut(){
    this.currentUserNameSource.next(null);
    localStorage.removeItem("user");
}

login(model: any) {
    return this.http.post<user>(this.baseUrl + 'login', model).pipe(
        map((response: user) => {
            const r = response;
            if (typeof releaseEvents !== 'undefined' && releaseEvents !== null) {
                
                localStorage.setItem('user', JSON.stringify(r));
                this.decodedToken = this.jwtHelper.decodeToken(r.token);
                this.currentUserNameSource.next(r);
                console.log(r);
            }
        })
    );
}
loggedIn() {
    const userstring:user = JSON.parse(localStorage.getItem('user'));
    const token = userstring.token;

    if(token !== undefined){
        if(this.jwtHelper.isTokenExpired(token)) {return false;} else {return true}
    }   
    else {return false;}
    
}

}
