import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { PrivateRoutingModule } from './private-routing.module';
import { paginaInicialComponent } from 'src/app/components/paginaInicial/paginaInicial.component';
import { contatoComponent } from 'src/app/components/contato/contato.component';
import { FullComponent } from 'src/app/layouts/full/full.component';
import { AppModule } from 'src/app/app.module';
import { HeaderComponent } from 'src/app/components/header/header.component';
import { PublicRoutingModule } from '../public/public-routing.module';


@NgModule({
  declarations: [
    HeaderComponent,
    paginaInicialComponent,
    contatoComponent,
    FullComponent
  ],
  imports: [
    CommonModule,
    PrivateRoutingModule,
    
    
  ]
})
export class PrivateModule { }
