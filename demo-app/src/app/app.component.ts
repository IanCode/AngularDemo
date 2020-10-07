import { Component } from '@angular/core';
import { WeatherDataService } from './services/weather-data.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent {
  title = 'Demo App';
  constructor(private weatherDataService: WeatherDataService){ }

  getWeatherData(): void {
    this.weatherDataService.getWeatherData();
  }
}
