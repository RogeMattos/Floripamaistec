import { HttpClient } from '@angular/common/http';
import { Component } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent {

  Home: FormGroup;

  constructor() {
    this.Home = new FormGroup({
      'nome': new FormControl('',[Validators.required, Validators.minLength(3)]),
      'email': new FormControl('',[Validators.required, Validators.email]),
      'nomeDoFilme': new FormControl('',[Validators.required, Validators.minLength(3)]),
      'avaliacao': new FormControl(null, [Validators.required, Validators.min(1), Validators.max(10)])
    })
  }
enviarFormulario(){
  const nomeFilme = this.Home.get('nomeDoFilme')?.value;
  alert(`Voce avaliou o filme ${nomeFilme}`);
}


}
