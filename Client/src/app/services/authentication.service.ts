import { Injectable } from '@angular/core';
import { map } from 'rxjs/operators';
import { HttpClient } from '@angular/common/http';
@Injectable({ providedIn: 'root' })
export class AuthenticationService {
  constructor(private http: HttpClient) { }
  private url: string;
  login(username: string, password: string) {
      console.log('sdadsfg');
      
      this.url = "https://localhost:44370/api/name/authenticate";
    return this.http.post<any>(this.url, { username: 'test1',password: 'password1'})
     .pipe(map(user => {
          
       if (user && user.token) {
          console.log(JSON.stringify(user))
          localStorage.setItem('currUser', JSON.stringify(user));
        }
       return user;
      }));
  }
 
  logout() {
    localStorage.removeItem('currUser');
  }
}