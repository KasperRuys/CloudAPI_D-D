import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { SubRacesComponent } from './sub-races.component';

describe('SubRacesComponent', () => {
  let component: SubRacesComponent;
  let fixture: ComponentFixture<SubRacesComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ SubRacesComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(SubRacesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
