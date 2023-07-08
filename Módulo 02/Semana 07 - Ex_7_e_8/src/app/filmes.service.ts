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
    return this.httpClient.get(environment.apiUrl + '/filmes/get-all')
  }

  
}
