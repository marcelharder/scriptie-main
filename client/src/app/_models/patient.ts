import { CAS } from "./cas";
import { GLI } from "./gli";

export interface Patient {
    id: number;
    height: number;
    weight: number;
    age: number;
    gender: string;
    feV1: string;
    tlc: string;
    rv: string;
    erv: string;
    ic: string;
    vc: string;
    gli: GLI;
    cas: CAS;
}