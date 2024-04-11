import { RouterModule, Routes } from "@angular/router";
import { DashboardComponent } from "./dashboard.component";
import { NgModule } from "@angular/core";
import { AppRoutingModule } from "src/app/app-routing.module";

const routes: Routes =[{
    path: '',
    component: DashboardComponent
}]

@NgModule({
    imports:[RouterModule.forChild(routes)],
    exports:[RouterModule]
})

export class DashboardRoatingModule{}