import { ComponentFixture, TestBed } from '@angular/core/testing';

import { PopupSignUpComponent } from './popup-sign-up.component';

describe('PopupSignUpComponent', () => {
  let component: PopupSignUpComponent;
  let fixture: ComponentFixture<PopupSignUpComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ PopupSignUpComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(PopupSignUpComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
