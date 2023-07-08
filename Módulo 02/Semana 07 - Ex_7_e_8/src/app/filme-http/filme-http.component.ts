import { Component } from '@angular/core';
import { FilmesService } from '../filmes.service';

@Component({
  selector: 'app-filme-http',
  templateUrl: './filme-http.component.html',
  styleUrls: ['./filme-http.component.css']
})
export class FilmeHttpComponent {

  constructor(private filmesService: FilmesService ) {}

  carregando = false;

  buscarFilmes(){
    this.carregando = true;
    this.filmesService.buscarFilmes().subscribe(resposta => {
      console.log(resposta);
      this.carregando = false;
    })
  } 

}
