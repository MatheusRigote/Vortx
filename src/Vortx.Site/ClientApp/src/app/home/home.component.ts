import { Component } from '@angular/core';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
})

export class HomeComponent {

  constructor() { }  

  OriginCity: any = "";
  DestinyCity: any = "";
  Plan: any = "";
  public Minute: string;

  regions = [
    {
      areaCode: 11,
      region: "São Paulo - Jundiaí - Itu - Bragança Paulista"
    },
    {
      areaCode: 16,
      region: "Ribeirão Preto - Franca - São Carlos - Araraquara"
    },
    {
      areaCode: 17,
      region: "São José do Rio Preto - Catanduva - Barretos - Votuporanga"
    },
    {
      areaCode: 18,
      region: "Presidente Prudente - Araçatuba - Birigui - Assis"
    }
  ];

  public plans = [
    {
      code : 0,
      name : "Padrão"
    },
    {
      code: 30,
      name: "Fale Mais 30"
    },
    {
      code: 60,
      name: "Fale Mais 60"
    },
    {
      code: 120,
      name: "Fale Mais 120"
    }
  ];

  originOnchange(value) {
    this.OriginCity = value;        
  }

  destinyOnchange(value) {
    this.DestinyCity = value;
  }

  planOnChange(value) {
    this.Plan = value;
  }

  minuteOnChange(value) {
    console.log(value);
  }

  btnCalculatte() {
    console.log(this.OriginCity);
    console.log(this.DestinyCity);
    console.log(this.Plan);
    console.log(this.Minute);
  }

}
