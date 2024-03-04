import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomeComponent } from './home/home.component';
import { StatisticsComponent } from './Statistics/Statistics.component';
import { PatientsComponent } from './Patients/Patients.component';
import { AboutComponent } from './About/About.component';
import { ListPatientsResolver } from './_resolvers/ListPatientsResolver';
import { AuthGuard } from './_guards/auth.guard';

const routes: Routes = [
  { path: '', component: HomeComponent },
  { path: 'about', component: AboutComponent },
  {
    path: '',
    runGuardsAndResolvers: 'always',
    canActivate: [AuthGuard],
    children: [
      { path: 'patients', component: PatientsComponent, resolve:{patients: ListPatientsResolver} },
      { path: 'statistics', component: StatisticsComponent },
        ]
  },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
