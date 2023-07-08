import { Component } from '@angular/core';
import { FilmesService } from '../filmes.service';
import { IFilme } from '../interfaces/IFilme';

@Component({
  selector: 'app-filme-http',
  templateUrl: './filme-http.component.html',
  styleUrls: ['./filme-http.component.css']
})
export class FilmeHttpComponent {
  carregando = false;
  filmesArray: IFilme[] = [];
  filmeAtual: IFilme | null = null;
  filmesTopTres: IFilme[] | null = null;
  indiceFilme = 0;

  constructor(private filmesService: FilmesService ) {
    this.filmesService.buscarFilmes().subscribe(resposta => {
      this.filmesArray = resposta;
      this.carregando = false;
      this.filmesTopTres = this.filmesService.buscarTopTres(resposta);
      this.filmeAtual = this.filmesTopTres[0];
      
    })
  }

  buscarFilmes(){
    this.carregando = true;
    this.filmesService.buscarFilmes().subscribe(resposta => {
      this.filmesArray = resposta
      this.carregando = false;
      console.log(resposta)
    })
  } 

  filmebemAvaliado() {
    const resultado = this.filmesService.filmeMelhorAvaliado(this.filmesArray);
    console.log(resultado);
  }

  proximo() {
    this.indiceFilme++;
    if (this.filmesTopTres != null)
      this.filmeAtual = this.filmesTopTres[this.indiceFilme];
  }
  
  anterior() {
    this.indiceFilme--;
    if (this.filmesTopTres != null)
      this.filmeAtual = this.filmesTopTres[this.indiceFilme];
  }

}
