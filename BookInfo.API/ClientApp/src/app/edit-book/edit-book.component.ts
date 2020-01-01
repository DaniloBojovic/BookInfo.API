import { Component, OnInit, Inject } from '@angular/core';
import { FormGroup, FormControl } from '@angular/forms';
import { MAT_DIALOG_DATA, MatDialogRef } from '@angular/material';
import { BookInfoService } from '../services/book-info.service';

@Component({
  selector: 'app-edit-book',
  templateUrl: './edit-book.component.html',
  styleUrls: ['./edit-book.component.css']
})
export class EditBookComponent implements OnInit {
  editForm: any;
  bookDetails: any;

  constructor(
    @Inject(MAT_DIALOG_DATA) public data: any,
    public dialogRef: MatDialogRef<EditBookComponent>,
    private bookInfoService: BookInfoService
  ) { this.bookDetails = data.bookDetails; }

  ngOnInit() {
    this.editForm = new FormGroup({
      title: new FormControl(this.bookDetails.title),
      author: new FormControl(this.bookDetails.author),
      description: new FormControl(this.bookDetails.description)
    });
  }

  onCancel() {
    this.dialogRef.close();
  }

  onSave() {
    this.bookInfoService.updateBook(this.bookDetails.id, this.editForm.value)
      .subscribe(res => this.dialogRef.close(res));
  }
}
