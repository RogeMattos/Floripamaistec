import { HttpClient } from '@angular/common/http';
import { Component } from '@angular/core';

@Component({
  selector: 'app-filme-http',
  templateUrl: './filme-http.component.html',
  styleUrls: ['./filme-http.component.css']
})
export class FilmeHttpComponent {
  constructor (private httpClient: HttpClient) {}

  
    buscarFilmes(){
      this.httpClient.get('https://536bd165-8e70-407c-8f3a-414083d3e973.mock.pstmn.io/filmes/get-all')
      .subscribe(resposta => {
        console.log(resposta);
      });
    }
  }

