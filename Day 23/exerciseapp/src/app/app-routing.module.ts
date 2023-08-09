import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AnimalsComponent } from './animals/animals.component';
import { BindingComponent } from './binding/binding.component';
import { HomeComponent } from './home/home.component';
import { PipeexComponent } from './pipeex/pipeex.component';

const routes: Routes = [
  {path:'', component:HomeComponent},
  {path:'pipe', component:PipeexComponent},
  {path:'binding', component:BindingComponent},
  {path:'animals', component:AnimalsComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
