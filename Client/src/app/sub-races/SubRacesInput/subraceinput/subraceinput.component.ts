import { Component, OnInit } from '@angular/core';
import { SubRacesComponent } from '../../sub-races.component';

@Component({
  selector: 'app-subraceinput',
  templateUrl: './subraceinput.component.html',
  styleUrls: ['./subraceinput.component.css']
})
export class SubraceinputComponent implements OnInit {

  constructor(private SubRaceComponent: SubRacesComponent) { }
  private _search: string = "";
  ngOnInit() {
  }


  get SearchSubRace() {
    return this._search;
  }
  set SearchSubRace(value: string) {
    this._search = value.toLowerCase();
    if(this._search != "") {
     this.SubRaceComponent.setFieldsSubRace(this._search)
      };
    }
  }


