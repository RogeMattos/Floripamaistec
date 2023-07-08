import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { paginaInicialComponent } from './components/paginaInicial/paginaInicial.component';
import { sobreComponent } from './components/sobre/sobre.component';
import { contatoComponent } from './components/contato/contato.component';
import { NotfoundComponent } from './components/notfound/notfound.component';
import { RouterModule, Routes } from '@angular/router';
import { FullComponent } from './layouts/full/full.component';
import { EsqueciSenhaComponent } from './components/esqueci-senha/esqueci-senha.component';
import { ContentComponent } from './layouts/content/content.component';
import { SignInComponent } from './components/sign-in/sign-in.component';


const routes: Routes = [

  { 
    path: '', 
    component: FullComponent,
    children: [
      { path: '', redirectTo: 'paginaInicial', pathMatch: 'full' },
      { path: 'paginaInicial', component: paginaInicialComponent },
      { path: 'Sobre', component: sobreComponent },
      { path: 'Contato', component: contatoComponent }
      
    ] 
  },

  { 
    path: 'content', 
    component: ContentComponent,
    children: [
      { path: 'Sign-in', component: SignInComponent },
      { path: 'Esqueci-senha', component: EsqueciSenhaComponent } 
     ]
      
  },

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }