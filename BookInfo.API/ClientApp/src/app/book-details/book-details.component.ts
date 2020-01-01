import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { BookInfoService } from '../services/book-info.service';

@Component({
  selector: 'app-book-details',
  templateUrl: './book-details.component.html',
  styleUrls: ['./book-details.component.css']
})
export class BookDetailsComponent implements OnInit {
  bookDetails: any;

  constructor(
    private route: ActivatedRoute,
    private bookService: BookInfoService) { }

  ngOnInit() {
    this.route.params.subscribe(params => {
      this.getBookById(params.id);
    });
  }

  getBookById(id: string) {
    this.bookService.getBookById(id)
      .subscribe(res => {
        this.bookDetails = res;
      });
  }
}

