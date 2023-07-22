import { Component, OnInit } from "@angular/core";
import { Observable } from "rxjs";
import { BEBIDAS_MOCK } from "src/app/shared/mocks/bebida-mock";
import { BebidaItem } from "src/app/shared/models/bebida-item.model";
import { AppService } from "src/app/shared/services/app.service";

@Component({
  selector: "nfd-bebida-listagem",
  templateUrl: "./bebida-listagem.component.html",
  styleUrls: ["./bebida-listagem.component.scss"],
})
export class BebidaListagemComponent {
  bebidaLista = BEBIDAS_MOCK;
}
