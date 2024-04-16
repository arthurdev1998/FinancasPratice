import { Component } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { SelectModel } from 'src/app/models/SelectModel';
import { MenuService } from 'src/services/menu/menu-service.service';

@Component({
  selector: 'app-despesa',
  templateUrl: './despesa.component.html',
  styleUrls: ['./despesa.component.scss']
})
export class DespesaComponent {

  constructor(public menuService: MenuService, public formBuilder: FormBuilder) {
  }

  listSistemas: Array<SelectModel> = new Array<SelectModel>();
  sistemaSelect = new SelectModel();

  
  listCategorias = new Array<SelectModel>();
  categoriaSelect = new SelectModel();



  despesaForm: FormGroup | any;

  ngOnInit() {
    this.menuService.menuSelecionado = 4;

    this.despesaForm = this.formBuilder.group
      (
        {
          name: ['', [Validators.required]],
          valor: ['', [Validators.required]],
          data: ['', [Validators.required]],
          sistemaSelect: ['', [Validators.required]],
          categoriaSelect: ['', [Validators.required]],
        }
      )
  }


  dadorForm() {
    return this.despesaForm.controls;
  }

  enviar() {
    debugger
    var dados = this.dadorForm();

    alert(dados["name"].value)
  }



}