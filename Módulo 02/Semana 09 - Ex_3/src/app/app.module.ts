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




@NgModule({
  declarations: [
    AppComponent,
    //paginaInicialComponent,
    //sobreComponent,
    //contatoComponent,
    HeaderComponent,
    //NotfoundComponent
  ],
  imports: [
    BrowserModule,
    RouterModule,
    AppRoutingModule
  
    
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
