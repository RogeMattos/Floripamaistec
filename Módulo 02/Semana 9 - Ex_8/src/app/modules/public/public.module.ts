import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { PublicRoutingModule } from './public-routing.module';
import { LoginComponent } from 'src/app/components/login/login.component';
import { EsqueciSenhaComponent } from 'src/app/components/esqueci-senha/esqueci-senha.component';
import { ContentComponent } from 'src/app/layouts/content/content.component';
import { FormGroup, FormsModule, ReactiveFormsModule } from '@angular/forms';
import { Router } from '@angular/router';


@NgModule({
  declarations: [
    LoginComponent,
    EsqueciSenhaComponent,
    ContentComponent
  ],
  imports: [
    CommonModule,
    PublicRoutingModule,
    ReactiveFormsModule,
    
    

  ]
})
export class PublicModule { }
