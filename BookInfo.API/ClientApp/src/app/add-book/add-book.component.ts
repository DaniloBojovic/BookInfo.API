import { Component, OnInit, Inject } from '@angular/core';
import { Validators, FormGroup, FormControl } from '@angular/forms';
import { MAT_DIALOG_DATA, MatDialogRef } from '@angular/material';
import { BookInfoService } from '../services/book-info.service';

@Component({
  selector: 'app-add-book',
  templateUrl: './add-book.component.html',
  styleUrls: ['./add-book.component.css']
})
export class AddBookComponent implements OnInit {
  editForm: any;

  constructor(
    @Inject(MAT_DIALOG_DATA) public data: any,
    public dialogRef: MatDialogRef<AddBookComponent>,
    private bookInfoService: BookInfoService
  ) { }

  ngOnInit() {
    this.editForm = new FormGroup({
      title: new FormControl(' ', Validators.required),
      author: new FormControl(' ', Validators.required),
      description: new FormControl(' ', Validators.required)
    });
  }

  onCancel() {
    this.dialogRef.close();
  }

  onSave() {
    this.bookInfoService.addBook(this.editForm.value)
      .subscribe(res => this.dialogRef.close(res));
  }

}
