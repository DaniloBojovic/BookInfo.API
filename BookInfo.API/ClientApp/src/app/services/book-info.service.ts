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

  addBook(request: any): Observable<any> {
    const url = `${this.baseUrl}/api/books`;
    return this.httpClient.post(url, request).pipe(
      map((body: any) => body),
      catchError(err => throwError(err))
    );
  }

  updateBook(id: string, request: any): Observable<any> {
    const url = `${this.baseUrl}/api/books/${id}`;
    const requestBody = {
      title: request.title,
      author: request.author,
      description: request.description,
      img: request.img
    };

    return this.httpClient.put(url, requestBody).pipe(
      map((body: any) => body),
      catchError(err => throwError(err))
    );
  }

  deleteBook(id: string): Observable<any> {
    const url = `${this.baseUrl}/api/books/${id}`;
    return this.httpClient.delete(url).pipe(
      map((body: any) => body),
      catchError(err => throwError(err))
    );
  }
}

