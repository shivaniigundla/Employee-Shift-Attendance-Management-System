import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({ providedIn: 'root' })
export class AuthService {
 private api='http://localhost:5000/api/auth';
 constructor(private http:HttpClient){}
 login(email:string,password:string){
   return this.http.post(`${this.api}/login`,{email,password});
 }
}
