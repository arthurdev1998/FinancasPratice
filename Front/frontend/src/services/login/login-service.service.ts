import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root'
})
export class LoginServiceService {

  private readonly baseUrl = environment["endPoint"]
  constructor(private httpCliente: HttpClient) { }

  login(Email: string, Password: string) {
    console.log()
    var obj =  this.httpCliente.post<any>(`${this.baseUrl}/CreateToken`,{Email: Email, Password: Password});
    return obj;
  }
}
