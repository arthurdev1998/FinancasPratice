import { RouterModule, Routes } from "@angular/router";
import { NgModule } from "@angular/core";
import { DespesaComponent } from "./despesa.component";

const routes: Routes =[{
    path: '',
    component: DespesaComponent
}]

@NgModule({
    imports:[RouterModule.forChild(routes)],
    exports:[RouterModule]
})

export class DespesaRoatingModule{}