import { RouterModule, Routes } from "@angular/router";
import { NgModule } from "@angular/core";
import { CategoriaComponent } from "./categoria.component";

const routes: Routes =[{
    path: '',
    component: CategoriaComponent
}]

@NgModule({
    imports:[RouterModule.forChild(routes)],
    exports:[RouterModule]
})

export class CategoriaRoatingModule{}