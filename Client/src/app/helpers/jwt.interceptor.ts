import { Injectable } from "@angular/core";
import { HttpRequest, HttpHandler, HttpEvent } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable()
export class JwtInterceptor implements JwtInterceptor {
    intercept(request: HttpRequest<any>, next: HttpHandler): Observable<HttpEvent<any>> {
        const currUser = JSON.parse(localStorage.getItem('currUser'));
        if(currUser && currUser.token) {
            request = request.clone({
                setHeaders: {
                    Authorization: `Bearer ${currUser.token}`
                }
            })
        }
        return next.handle(request);
    }
}