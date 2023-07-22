import { Component } from '@angular/core';
import { CardapioItem } from 'src/app/shared/models/cardapio-item-model';

@Component({
  selector: 'nfd-cardapio',
  templateUrl: './cardapio.component.html',
  styleUrls: ['./cardapio.component.scss']
})
export class CardapioComponent {
  infoApresentacao = {
    titulo: 'NgFood',
    descricao: ` Localizado em um ambiente acolhedor, o Restaurante Ng-Food é conhecido
     por seu cardápio diversificado e pratos exuberantes. Com chefs talentosos e experientes, oferecemos
      uma experiência gastronômica única, onde os clientes podem desfrutar de sabores sofisticados e memoráveis.
       Nosso ambiente é perfeito para encontros e celebrações especiais. Venha nos visitar e encante-se com a deliciosa
        culinária que temos para oferecer.,`,
    tituloBotao:'Cardápio'
  }

  itensCardapio: CardapioItem [] = [
    {
      
      titulo:'Comidas',
      urlImagem:'assets/img/feijoada.jpg',
      path:''
    },

    { 
      titulo:'Bebidas',
      urlImagem:'assets/img/bebidas.jpg',
      path:''
    }
  ]
}


