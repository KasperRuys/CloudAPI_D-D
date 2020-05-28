import { Component, OnInit } from '@angular/core';
import { SubraceService } from './subrace.service';
import { SubRace } from './subraceInterface';
import { Subrace } from '../internet-api/OnlineAPI';

@Component({
  selector: 'app-sub-races',
  templateUrl: './sub-races.component.html',
  styleUrls: ['./sub-races.component.css']
})
export class SubRacesComponent implements OnInit {

  constructor(private subraceService: SubraceService) { }
  SubRace: Subrace;

  setFieldsSubRace(value: string){
    this.subraceService.getSubRaces(value).subscribe(data=>{
    this.SubRace = data
    });
  }


  ngOnInit() {
  }

}
