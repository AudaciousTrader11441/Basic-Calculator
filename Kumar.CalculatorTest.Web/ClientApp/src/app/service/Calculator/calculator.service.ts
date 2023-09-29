import { Injectable, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class CalculatorService {
  constructor(private http: HttpClient, @Inject('BASE_URL') private baseUrl: string) {}

  add(number1: number, number2: number): Observable<number> {
    return this.http.post<number>(`${this.baseUrl}calculator/add`, { number1, number2 });
  }

  subtract(number1: number, number2: number): Observable<number> {
    return this.http.post<number>(`${this.baseUrl}calculator/subtract`, { number1, number2 });
  }
}
