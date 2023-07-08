import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { FullComponent } from './layouts/full/full.component';
import { NotfoundComponent } from './components/notfound/notfound.component';
import { NotFoundLayoutComponent } from './layouts/not-found-layout/not-found-layout.component';
import { emailPrivateGuard, emailPublicGuard } from './guards/email.guard';


const routes: Routes = [
   
  { path:'', redirectTo: 'public/login', pathMatch:'full'},

  { 
    path: 'private', 
    canActivate: [ emailPrivateGuard ],
    loadChildren: ()  => import('./modules/private/private.module').then(m=>m.PrivateModule)
  },
  
  { 
    path: 'public', 
    canActivate: [ emailPublicGuard ],
    loadChildren: ()  => import('./modules/public/public.module').then(m=>m.PublicModule)
  },

  { 
    path: '**',
    component: NotFoundLayoutComponent,
    children: [
      { path:'', component: NotfoundComponent}
    ]
  }
 

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule],
  

})
export class AppRoutingModule { }