import { NgModule } from "@angular/core";
import { CommonModule } from "@angular/common";
import { NavbarModule } from "src/app/components/navbar/navbar.module";
import { SidebarModule } from "src/app/components/sidebar/sidebar.module";
import { DashboardModule } from "../dashboard/dashboard.module";
import { DespesaComponent } from "./despesa.component";
import { DespesaRoatingModule } from "./despesa-routing.module";

@NgModule({
    providers:[],
    declarations:[DespesaComponent],
    imports:[
        CommonModule,
        DespesaRoatingModule,
        NavbarModule,
        SidebarModule,
        DashboardModule
    ]
})

export class CategoriaModule{}