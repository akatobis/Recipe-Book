import { ComponentFixture, TestBed } from '@angular/core/testing';

import { PopupSignInComponent } from './popup-sign-in.component';

describe('PopupSignInComponent', () => {
  let component: PopupSignInComponent;
  let fixture: ComponentFixture<PopupSignInComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ PopupSignInComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(PopupSignInComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
