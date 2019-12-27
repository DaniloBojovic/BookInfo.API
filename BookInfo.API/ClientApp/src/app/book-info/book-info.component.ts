import { Component, OnInit } from '@angular/core';
import { BookInfoService } from '../services/book-info.service';
import { MatTableDataSource } from '@angular/material';

@Component({
  selector: 'app-book-info',
  templateUrl: './book-info.component.html',
  styleUrls: ['./book-info.component.css']
})
export class BookInfoComponent implements OnInit {
  books: any;
  booksColumns: string[] = ['title', 'author', 'menu'];
  booksSource = new MatTableDataSource<any>();

  constructor(private bookInfoService: BookInfoService) { }

  ngOnInit() {
    this.getBooks();
  }

  getBooks() {
    this.bookInfoService.getBooks()
      .subscribe(res => {
        this.booksSource = res;
        console.log(this.books);
      });
  }

  openModal(row): void {
    console.log('row: ', row);
  }

  edit(): void {
    console.log('edit()');
  }

  delete(): void {
    console.log('delete()');
  }
}
