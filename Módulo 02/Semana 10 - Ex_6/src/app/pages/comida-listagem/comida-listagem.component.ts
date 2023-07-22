import { Component } from "@angular/core";
import { COMIDAS_MOCK } from "src/app/shared/mocks/comida-mock";
import { ComidaItem } from "src/app/shared/models/comida-item.model";

@Component({
  selector: "nfd-comida-listagem",
  templateUrl: "./comida-listagem.component.html",
  styleUrls: ["./comida-listagem.component.scss"],
})
export class ComidaListagemComponent {
  comidaLista: ComidaItem[] = COMIDAS_MOCK;
}
