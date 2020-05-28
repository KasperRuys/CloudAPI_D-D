import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { HttpClientModule  } from '@angular/common/http';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { InternetAPIComponent } from './internet-api/internet-api.component';
import { FormsModule } from '@angular/forms';

import { AngularFireModule } from '@angular/fire';
import { AngularFireAnalyticsModule } from '@angular/fire/analytics';
import { AngularFirestoreModule } from '@angular/fire/firestore';
import { AngularFireAuthModule } from "@angular/fire/auth";


import { environment } from '../environments/environment'

import { RouterModule} from '@angular/router';

import { SubRacesComponent } from './sub-races/sub-races.component';
import { RacesComponent } from './races/races.component';
import { ClassesComponent } from './Classes/classes.component';
import { TheclassComponent } from './internet-api/Class/theclass/theclass.component';
import { TheraceComponent } from './internet-api/Race/therace/therace.component';
import { ThespellsComponent } from './internet-api/Spells/thespells/thespells.component';


@NgModule({
  declarations: [
    AppComponent,
    InternetAPIComponent,
    RacesComponent,
    SubRacesComponent,
    ClassesComponent,
    TheclassComponent,
    TheraceComponent,
    ThespellsComponent,
  ],
  imports: [
    AngularFireModule.initializeApp(environment.firebase),
    AngularFireAnalyticsModule,
    AngularFirestoreModule,
    AngularFireAuthModule,
    BrowserModule,
    HttpClientModule,
    AppRoutingModule,
    FormsModule,
    RouterModule.forRoot([
      { path: "API", component: InternetAPIComponent},
      { path: "Classes", component: ClassesComponent},
      { path: "Races", component: RacesComponent},
      { path: "SubRaces", component: SubRacesComponent}
    ])
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
