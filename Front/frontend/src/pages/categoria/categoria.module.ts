import { NgModule } from "@angular/core";
import { CommonModule } from "@angular/common";
import { NavbarModule } from "src/app/components/navbar/navbar.module";
import { SidebarModule } from "src/app/components/sidebar/sidebar.module";
import { CategoriaRoatingModule } from "./categoria-routing.module";
import { CategoriaComponent } from "./categoria.component";
import { DashboardModule } from "../dashboard/dashboard.module";

@NgModule({
    providers:[],
    declarations:[CategoriaComponent],
    imports:[
        CommonModule,
        CategoriaRoatingModule,
        NavbarModule,
        SidebarModule,
        DashboardModule
    ]
})

export class CategoriaModule{}