import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable, of } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class WeatherDataService {

  private weatherBaseUrl = 'https://localhost:5001/Weather/data';

  constructor(private client: HttpClient){
    
  }

  getWeatherData(): Observable<string> {
    var poop = this.client.get<string>(this.weatherBaseUrl);
    return poop;
  }
}
