import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { HttpClientModule, HTTP_INTERCEPTORS  } from '@angular/common/http';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { InternetAPIComponent } from './internet-api/internet-api.component';
import { FormsModule } from '@angular/forms';


import { RouterModule} from '@angular/router';

import { SubRacesComponent } from './sub-races/sub-races.component';
import { RacesComponent } from './races/races.component';
import { ClassesComponent } from './Classes/classes.component';
import { TheclassComponent } from './internet-api/Class/theclass/theclass.component';
import { TheraceComponent } from './internet-api/Race/therace/therace.component';
import { ThespellsComponent } from './internet-api/Spells/thespells/thespells.component';
import { LoginComponentComponent } from './login-component/login-component.component';
import { JwtInterceptor } from './helpers/jwt.interceptor';
import { SubraceinputComponent } from './sub-races/SubRacesInput/subraceinput/subraceinput.component';


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
    LoginComponentComponent,
    SubraceinputComponent,
  ],
  imports: [
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
  providers: [{
    provide: HTTP_INTERCEPTORS, useClass: JwtInterceptor, multi: true
  }],
  bootstrap: [AppComponent]
})
export class AppModule { }
