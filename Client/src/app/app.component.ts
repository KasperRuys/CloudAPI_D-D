import { Component } from '@angular/core';
import { AuthenticationService } from './services/authentication.service';
import { HttpClient } from '@angular/common/http';
import { first } from 'rxjs/operators';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'DNDAPI Project Kasper';
  //constructor(firestore: AngularFirestore) {
   // this.items = firestore.collection('items').valueChanges();
  //}

  email: string;
  password: string;
  constructor(public authenticationService: AuthenticationService, private http: HttpClient) {}

  /*signUp() {
    this.authenticationService.SignUp(this.email, this.password);
    this.email = ''; 
    this.password = '';
  }

  signIn() {
    this.email = ''; 
    this.password = '';
  }

  signOut() {
    this.authenticationService.SignOut();
  }*/

  signIn() {  
    return this.authenticationService.login(this.email, this.password).pipe(first()).subscribe(data => console.log(data));

    //this.authenticationService.login(this.email, this.password);
  }
  test() {
    return this.http.get<any>('https://localhost:44370/api/race').subscribe(data => console.log(data));
  }
}