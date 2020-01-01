import { Component, OnInit, Inject } from '@angular/core';
import { BookInfoService } from '../services/book-info.service';
import { MatTableDataSource } from '@angular/material';
import { MatDialog } from '@angular/material/dialog';
import { EditBookComponent } from '../edit-book/edit-book.component';
import { AddBookComponent } from '../add-book/add-book.component';

@Component({
  selector: 'app-book-info',
  templateUrl: './book-info.component.html',
  styleUrls: ['./book-info.component.css']
})
export class BookInfoComponent implements OnInit {
  books: any;
  booksColumns: string[] = ['title', 'author', 'menu'];
  booksSource = new MatTableDataSource<any>();

  constructor(
    private bookInfoService: BookInfoService,
    public dialog: MatDialog) { }

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

  edit(element): void {
    console.log('eleme ', element);
    const dialogRef = this.dialog.open(EditBookComponent, {
      width: '500px',
      data: { bookDetails: element }
    });

    dialogRef.afterClosed().subscribe(res => {
      this.getBooks();
    });
  }

  delete(element): void {
    this.bookInfoService.deleteBook(element.id)
      .subscribe(res => {
        this.getBooks();
      });
  }

  add(): void {
    const dialogRef = this.dialog.open(AddBookComponent, {
      width: '500px',
    });

    dialogRef.afterClosed().subscribe(res => {
      this.getBooks();
    });
  }
}
