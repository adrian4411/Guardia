
import { Component,Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Servicio } from '../Servicio/TestService';


@Component({
  selector: 'app-counter-component',
  templateUrl: './counter.component.html'
})



  
export class CounterComponent {
  public currentCount = 0;
  public prueba: Servicio;
  //El constructor puede tener solo un parametro como varios
  constructor(protected service: Servicio) {
    this.prueba = service;
    }
  

  public incrementCounter() {
    this.currentCount++;
  }
}
