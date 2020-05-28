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
  postData = 
  {
    "id": 7,
  "subRaceName": "strg",
  "subraceFeatures": "string55",
  "raceID": 5
  }
  putData ={
    "id": 3,
    "subRaceName": "test",
    "subraceFeatures": "test",
    "raceID": 7
  }
  json;
  constructor(private http: HttpClient, private SubRaceService: SubraceService) { }

  getSubRaces(value: string){
    return this.http.get<Subrace>("https://localhost:44370/api/Subrace/Subraces/" + value);
  
  }

  PostSubRaces2(value: string){
    return this.http.post("https://localhost:44370/api/Subrace/AddSubRace",this.postData).toPromise().then((data:any) =>{
      console.log(data);
      this.json = JSON.stringify(data.json);
      
    });
  
  }
  PutSubRaces2(value: string){
    return this.http.put("https://localhost:44370/api/Subrace/AddSubRace",this.putData).toPromise().then((data:any) =>{
      console.log(data);
      this.json = JSON.stringify(data.json);
      
    });
  
  }


  
  deleteDataFromAPI()
  {
    this.http.delete(`https://localhost:44370/api/Subrace/${this.subraceID}`)
        .subscribe(
          res => {
            console.log(res);
          },
          err => {
            console.log("Error occured");
          }
        );
  }

  getDataFromAPI()
  {
    return this.http.get(`https://localhost:44370/api/Subrace/Races/${this.subraceID}`)
    .pipe(map(res => res))
   }

   getSubRace2()
   {
     this.getDataFromAPI().subscribe(data => {
       this.data = data   
     })
   }

}
