import { NgModule } from "@angular/core";
import { CommonModule } from "@angular/common";
import { NavbarModule } from "src/app/components/navbar/navbar.module";
import { SidebarModule } from "src/app/components/sidebar/sidebar.module";
import { SistemaComponent } from "./sistema.component";
import { SistemaRoatingModule } from "./sistema-routing.module";
import { FormGroupName, ReactiveFormsModule } from "@angular/forms";

@NgModule({
    providers:[],
    declarations:[SistemaComponent],
    imports:[
        CommonModule,
        SistemaRoatingModule,
        NavbarModule,
        SidebarModule,
        ReactiveFormsModule
    ]
})

export class SistemaModule{}