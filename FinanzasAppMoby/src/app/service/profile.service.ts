import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class ProfileService {

  constructor(private http:HttpClient) { 
    console.log("El servicio esta corriendo")
  }
  //Observable<any> lo convierte en asincronico a la espera del server
  getProfile():Observable<any>
  {
    //url de los datos de la api, despues cambiar por el url del metodo get que traiga info del perfil
    return this.http.get('http://localhost:3000/profile')

  }
}
