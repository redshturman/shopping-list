import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class MainListService {
  
  constructor(private http: HttpClient) { }

  getMainList(): Observable<any> {
    return this.http.get('https://localhost:32769/api/Products/GetProducts');
  }
    
}
