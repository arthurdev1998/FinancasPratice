import { RouterModule, Routes } from "@angular/router";
import { NgModule } from "@angular/core";
import { SistemaComponent } from "./sistema.component";

const routes: Routes =[{
    path: '',
    component: SistemaComponent
}]

@NgModule({
    imports:[RouterModule.forChild(routes)],
    exports:[RouterModule]
})

export class SistemaRoatingModule{}