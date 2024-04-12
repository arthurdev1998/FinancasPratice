import { Component, OnInit } from '@angular/core';
import { MenuService } from 'src/services/menu/menu-service.service';

@Component({
  selector: 'app-categoria',
  templateUrl: './categoria.component.html',
  styleUrls: ['./categoria.component.scss']
})
export class CategoriaComponent implements OnInit {

  constructor(public menuService: MenuService)
  {}
  ngOnInit(): void {
    this.menuService.menuSelecionado = 3;
  }
}
