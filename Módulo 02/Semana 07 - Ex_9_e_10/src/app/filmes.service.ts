import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment.development';
import { IFilme } from './interfaces/IFilme';

@Injectable({
  providedIn: 'root'
})
export class FilmesService {

  constructor(private httpClient: HttpClient) { }
  
  buscarFilmes(){
    return this.httpClient.get<IFilme[]>(environment.apiUrl + '/filmes/get-all')
  }

  filmeMelhorAvaliado(filmesArray: IFilme[]) {

    return filmesArray.reduce(function(filmPrev, filmeAtual){
      return filmPrev.notaIMDb > filmeAtual.notaIMDb ? filmPrev : filmeAtual;
    });

  }

  buscarTopTres(filmesArray: IFilme[]) {
    let filmesArrayCopia: IFilme[] = filmesArray;
    let topTres: IFilme[] = [];
    
    for (let index = 0; index < 3; index++) {
      topTres.push(this.filmeMelhorAvaliado(filmesArrayCopia));
      filmesArrayCopia.splice(filmesArrayCopia.indexOf(topTres[index]), 1);
    }
    return topTres
  }

  
}
