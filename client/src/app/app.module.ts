import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';



import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { NavComponent } from './nav/nav.component';
import { HomeComponent } from './home/home.component';
import { PatientsComponent } from './Patients/Patients.component';
import { StatisticsComponent } from './Statistics/Statistics.component';
import { AuthService } from './_services/auth.service';
import { HttpClientModule } from '@angular/common/http';
import { JwtModule } from '@auth0/angular-jwt';
import { FormsModule } from '@angular/forms';
import { AboutComponent } from './About/About.component';
import { PatientService } from './_services/Patient.service';
import { ListPatientsResolver } from './_resolvers/ListPatientsResolver';
import { AuthGuard } from './_guards/auth.guard';
import { ToastrModule } from 'ngx-toastr';

export function tokenGet() { return localStorage.getItem('token'); }

@NgModule({
  declarations: [					
    AppComponent,
      NavComponent,
      HomeComponent,
      PatientsComponent,
      StatisticsComponent,
      AboutComponent
   ],
  imports: [
    FormsModule,
    BrowserModule,
    ToastrModule.forRoot({
      positionClass: 'toast-bottom-right'
    }),
    AppRoutingModule,
    HttpClientModule,
    JwtModule.forRoot({
      config: {
          tokenGetter: tokenGet,
          allowedDomains: ['localhost:5000'],
          disallowedRoutes: ['localhost:5000/api/auth']
      }
  }),
  ],
  providers: [AuthService,PatientService,ListPatientsResolver,AuthGuard],
  bootstrap: [AppComponent]
})
export class AppModule { }
