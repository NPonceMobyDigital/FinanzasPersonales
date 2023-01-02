import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';


@Injectable({
  providedIn: 'root'
})

export class BillsService {

  constructor(private http:HttpClient) { 

  }

  //Observable<any> lo convierte en asincronico a la espera del server
  getBills():Observable<any>
  {
    //url de los datos de la api, despues cambiar por el url del metodo get que traiga info de los gastos
    return this.http.get('http://localhost:3000/bills')

  }
}
