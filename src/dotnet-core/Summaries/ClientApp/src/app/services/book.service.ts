import { Inject, Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Book } from '../interfaces/book';


@Injectable({
  providedIn: 'root'
})
export class BookService {

  _baseURL: string;

  constructor(private http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    this._baseURL = baseUrl + "api/Books";
  }
  getAllBooks(){
    return this.http.get<Book[]>(this._baseURL + "/GetBooks");
  }

}
