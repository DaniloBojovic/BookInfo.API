import { Injectable, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable, throwError } from 'rxjs';
import { map, catchError } from 'rxjs/operators';


@Injectable({
  providedIn: 'root'
})
export class BookInfoService {

  constructor(
    private httpClient: HttpClient,
    @Inject('BASE_API_URL') private baseUrl: string) { }

  getBooks(): Observable<any> {
    const url = `${this.baseUrl}/api/books`;
    return this.httpClient.get(url).pipe(
      map((body: any) => body),
      catchError(err => throwError(err))
    );
  }

  getBookById(id: string): Observable<any> {
    const url = `${this.baseUrl}/api/books/${id}`;
    return this.httpClient.get(url).pipe(
      map((body: any) => body),
      catchError(err => throwError(err))
    );
  }
}

