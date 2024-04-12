import { Component, OnInit } from '@angular/core';
import { MenuService } from 'src/services/menu/menu-service.service';

@Component({
  selector: 'despesa',
  templateUrl: './despesa.component.html',
  styleUrls: ['./despesa.component.scss']
})
export class DespesaComponent implements OnInit {

  constructor(public menuService: MenuService)
  {}
  ngOnInit(): void {
    this.menuService.menuSelecionado = 4;
  }
}
