import { NgModule } from "@angular/core";
import { DashboardComponent } from "./dashboard.component";
import { CommonModule } from "@angular/common";
import { DashboardRoatingModule } from "./dashboard-routing.module";

@NgModule({
    providers:[],
    declarations:[DashboardComponent],
    imports:[
        CommonModule,
        DashboardRoatingModule
    ]
})

export class DashboardModule{}