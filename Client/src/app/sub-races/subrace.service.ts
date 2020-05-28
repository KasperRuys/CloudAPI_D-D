import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { map } from 'rxjs/operators';
import { Subrace } from '../internet-api/OnlineAPI';

@Injectable({
  providedIn: 'root'
})
export class SubraceService {
  subraceID:Int16Array
  subRaceName:String
  subraceFeatures:String
  raceID:Int16Array
  data: any = {};
  constructor(private http: HttpClient) { }

  getSubRaces(value: string){
    return this.http.get<Subrace>("https://localhost:44370/api/Subrace/Subraces/" + value);
  }

}
