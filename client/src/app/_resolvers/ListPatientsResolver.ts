import { Injectable } from "@angular/core";
import { ActivatedRouteSnapshot, Resolve, Router } from "@angular/router";
import { Patient } from "../_models/patient";
import { Observable, catchError, of } from "rxjs";
import { PatientService } from "../_services/Patient.service";

@Injectable()
export class ListPatientsResolver implements Resolve<Patient[]> {
   
    constructor(private p: PatientService,
                private router: Router) { }

    resolve(route: ActivatedRouteSnapshot): Observable<Patient[]> {
        return this.p.getListOfPatients().pipe(
                catchError(error => {
                    this.router.navigate(['/home']);
                    return of(null);
                })
            );

    }
}