import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({ providedIn: 'root' })
export class ShiftsService {
 private api='http://localhost:5000/api/shifts';
 constructor(private http:HttpClient){}
 getShifts(){ return this.http.get(this.api); }
}
