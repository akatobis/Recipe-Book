import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CardInfoProfileComponent } from './card-info-profile.component';

describe('CardInfoProfileComponent', () => {
  let component: CardInfoProfileComponent;
  let fixture: ComponentFixture<CardInfoProfileComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ CardInfoProfileComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(CardInfoProfileComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
