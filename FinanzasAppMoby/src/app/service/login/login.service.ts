import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable, observable } from 'rxjs';
import { LoginStar } from 'src/app/Models/loginStar';

@Injectable({
  providedIn: 'root'
})
export class LoginService {

  constructor(private http:HttpClient) { }

  starSession(loginStar:LoginStar):Observable<any>
  {
    return this.http.post('http://localhost:3000/profile',loginStar);
  }

  
}
