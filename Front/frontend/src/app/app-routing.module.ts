import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { LoginComponent } from 'src/pages/login/login.component';

const routes: Routes = [
  {
    path: '',
    pathMatch: 'full',
    redirectTo: 'login'
  },
  { path: 'login', component: LoginComponent },
  { path: '', component: LoginComponent },
  { path: 'dashboard', loadChildren: () => import('../pages/dashboard/dashboard.module').then(m => m.DashboardModule),},
  { path: 'despesa', loadChildren: () => import('../pages/despesa/despesa.module').then(m => m.DespesaModule),},
  { path: 'sistema', loadChildren: () => import('../pages/sistema/sistema.module').then(m => m.SistemaModule),},
  { path: 'categoria', loadChildren: () => import('../pages/categoria/categoria.module').then(m => m.CategoriaModule),}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }