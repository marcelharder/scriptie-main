import { Injectable } from '@angular/core';
import { Patient } from '../_models/patient';
import { HttpClient } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { CAS } from '../_models/cas';
import { GLI } from '../_models/gli';

@Injectable({
  providedIn: 'root'
})
export class PatientService {
  baseUrl: string = environment.apiUrl;
  constructor(private http: HttpClient) { }

  getListOfPatients() {return this.http.get<Patient[]>(this.baseUrl + "getPatientList");}

  getSpecificPatient(id: number){return this.http.get<Patient>(this.baseUrl + "getSpecificPatient/" + id)}

  updatePatient(p: Patient){return this.http.put<string>(this.baseUrl + "UpdatePatient",p)}
    
  addPatient(){return this.http.post<Patient>(this.baseUrl + "AddPatient", null)}

  calculateCas(id: number, value: string) {  return this.http.get<CAS>(this.baseUrl + "calculateCAS/" + id + "/" + value) }

  calculateGli(id: number, value: string) {  return this.http.get<GLI>(this.baseUrl + "calculateGli/" + id + "/" + value) }





}
