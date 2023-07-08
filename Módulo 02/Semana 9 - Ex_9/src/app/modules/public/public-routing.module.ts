import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { EsqueciSenhaComponent } from 'src/app/components/esqueci-senha/esqueci-senha.component';
import { LoginComponent } from 'src/app/components/login/login.component';
import { ContentComponent } from 'src/app/layouts/content/content.component';

const routes: Routes = [
  {
    path:'',
    component: ContentComponent,
    children: [
      { path: 'login', component: LoginComponent},
      { path: 'Esqueci-senha', component: EsqueciSenhaComponent},
    ]
  }

];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class PublicRoutingModule { }
