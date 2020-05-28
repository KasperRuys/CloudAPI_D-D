import { Injectable } from "@angular/core";
import { CanActivate, ActivatedRouteSnapshot, RouterStateSnapshot, Router } from '@angular/router';
import { IfStmt } from '@angular/compiler';
import { AuthenticationService } from '../services/authentication.service';

@Injectable({providedIn: 'root'})
export class UserGuard implements CanActivate {
    constructor(router: Router, private authService: AuthenticationService) {}
        canActivate(route: ActivatedRouteSnapshot, state: RouterStateSnapshot) {
            const user = JSON.parse(localStorage.getItem('currUser'));
            if(localStorage.getItem('currUser') !== null) {
                return true;
            }
            return false;
        }

    }