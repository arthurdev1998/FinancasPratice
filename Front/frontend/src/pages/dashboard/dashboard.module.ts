import { NgModule } from "@angular/core";
import { DashboardComponent } from "./dashboard.component";
import { CommonModule } from "@angular/common";
import { DashboardRoatingModule } from "./dashboard-routing.module";
import { NavbarModule } from "src/app/components/navbar/navbar.module";
import { SidebarModule } from "src/app/components/sidebar/sidebar.module";

@NgModule({
    providers:[],
    declarations:[DashboardComponent],
    imports:[
        CommonModule,
        DashboardRoatingModule,
        NavbarModule,
        SidebarModule
    ]
})

export class DashboardModule{}