import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class BaseService {

  constructor( private http: HttpClient) { }

  getAll() {
    // 7158 a tanár úré
    return this.http.get("https://localhost:7275/api/players")
  }
}
