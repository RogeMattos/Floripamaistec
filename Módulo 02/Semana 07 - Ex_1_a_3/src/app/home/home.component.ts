import { Component } from '@angular/core';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent {
  //Exercício 02 -----------
  digita = '';
  
  //Exercício 3-------------
  numero1 = 0;
  numero2 = 0;
  resultado = 0;

 
  somar() {
    this.resultado = this.numero1 + this.numero2;
  }

  subtrair() {
    this.resultado = this.numero1 - this.numero2;
  }

  multiplicar() {
    this.resultado = this.numero1 * this.numero2;
  }

  dividir() {
    this.resultado = this.numero1 / this.numero2;
  }
  limpar() {
    this.numero1 = 0;
    this.numero2 = 0;
    this.resultado = 0;
  }


}

    

  
   




