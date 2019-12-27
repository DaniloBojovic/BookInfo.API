import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HttpClientModule } from '@angular/common/http';
import { BookInfoComponent } from './book-info/book-info.component';
import { RouterModule } from '@angular/router';
import { environment } from '../environments/environment';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { MatIconModule, MatListModule, MatTableModule, MatMenuModule, MatButtonModule, MatCardModule } from '@angular/material';
import { BookDetailsComponent } from './book-details/book-details.component';

@NgModule({
  declarations: [
    AppComponent,
    BookInfoComponent,
    BookDetailsComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    RouterModule.forRoot([
      { path: 'books', component: BookInfoComponent },
      { path: 'books/:id', component: BookDetailsComponent }
    ]),
    BrowserAnimationsModule,
    MatIconModule,
    MatListModule,
    MatTableModule,
    MatMenuModule,
    MatButtonModule,
    MatCardModule
  ],
  providers: [
    { provide: 'BASE_API_URL', useValue: environment.apiUrl }
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
