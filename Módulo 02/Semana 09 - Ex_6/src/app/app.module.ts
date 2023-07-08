import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import {  paginaInicialComponent } from './components/paginaInicial/paginaInicial.component';
import {  sobreComponent } from './components/sobre/sobre.component';
import {  contatoComponent } from './components/contato/contato.component';
import { HeaderComponent } from './components/header/header.component';
import { RouterModule, Routes } from '@angular/router';
import { NotfoundComponent } from './components/notfound/notfound.component';
import { AppRoutingModule } from './app-routing.module';
import { FullComponent } from './layouts/full/full.component';
import { ContentComponent } from './layouts/content/content.component';
import { SignInComponent } from './components/sign-in/sign-in.component';
import { EsqueciSenhaComponent } from './components/esqueci-senha/esqueci-senha.component';
import { LoginComponent } from './components/login/login.component';
import { ReactiveFormsModule } from '@angular/forms';




@NgModule({
  declarations: [
    AppComponent,
    //paginaInicialComponent,
    //sobreComponent,
    //contatoComponent,
    HeaderComponent,
    FullComponent,
    ContentComponent,
    SignInComponent,
    EsqueciSenhaComponent,
    LoginComponent,
    //NotfoundComponent
  ],
  imports: [
    BrowserModule,
    RouterModule,
    AppRoutingModule,
    ReactiveFormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
