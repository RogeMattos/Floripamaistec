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
import { LoginComponent } from './components/login/login.component';


const routes: Routes = [
   
  { path:'', redirectTo: 'public/login', pathMatch:'full'},

  { 
    path: 'private', 
    loadChildren: ()  => import('./modules/private/private.module').then(m=>m.PrivateModule)
  },
  
  { 
    path: 'public', 
    loadChildren: ()  => import('./modules/public/public.module').then(m=>m.PublicModule)
  },
 

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule],
  

})
export class AppRoutingModule { }