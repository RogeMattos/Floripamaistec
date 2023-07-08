import { Component, EventEmitter, Output } from '@angular/core';

@Component({
  selector: 'app-busca',
  templateUrl: './busca.component.html',
  styleUrls: ['./busca.component.scss']
})
export class BuscaComponent {
  
  @Output() busca = new EventEmitter<string>();

  mudanca(event: any): void {
    const text = event.target.value;
    console.log(text);
    
  }
}

