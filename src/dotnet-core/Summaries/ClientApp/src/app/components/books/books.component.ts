import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-books',
  templateUrl: './books.component.html',
  styleUrls: ['./books.component.css']
})
export class BooksComponent implements OnInit {
  
  public books: Book[];

  constructor() { 
    // Initialization inside the constructor
   //this.books = [];
  }

  ngOnInit() {

  }

}
