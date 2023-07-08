import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { paginaInicialComponent } from 'src/app/components/paginaInicial/paginaInicial.component';
import { sobreComponent } from 'src/app/components/sobre/sobre.component';
import { FullComponent } from 'src/app/layouts/full/full.component';

const routes: Routes = [

  {
    path:'',
    component: FullComponent,

    children: [
      { path:'paginaInicial', component: paginaInicialComponent },
      { path: 'Sobre', component: sobreComponent}
    ]

  }
  
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class PrivateRoutingModule { }
