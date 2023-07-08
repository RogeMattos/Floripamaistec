import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { AppComponent } from './app.component';
import { RouterModule, Routes } from '@angular/router';
import { AppRoutingModule } from './app-routing.module';
import { SignInComponent } from './components/sign-in/sign-in.component';
import { ReactiveFormsModule } from '@angular/forms';
import { NotFoundLayoutComponent } from './layouts/not-found-layout/not-found-layout.component';

@NgModule({
  declarations: [
    AppComponent,
    SignInComponent,
    NotFoundLayoutComponent,
    
  ],
  imports: [
    BrowserModule,
    RouterModule,
    AppRoutingModule,
    ReactiveFormsModule,
    
  ],
  providers: [],
  bootstrap: [AppComponent],
  
})
export class AppModule { }
