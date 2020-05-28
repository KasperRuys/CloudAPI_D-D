import { Component, OnInit } from '@angular/core';
import { AuthenticationService } from '../services/authentication.service';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-login-component',
  templateUrl: './login-component.component.html',
  styleUrls: ['./login-component.component.css']
})
export class LoginComponentComponent implements OnInit {
  email: string;
  password: string;
  constructor(private authenticationService: AuthenticationService, private http: HttpClient) { }

  ngOnInit() {
  }
  signIn() {  
    console.log('sadasf');
    
    return this.http.get("https://localhost:44370/api/race");
  
    //this.authenticationService.login(this.email, this.password);
  }
}
