import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ButtonAuthorizationComponent } from './button-authorization.component';

describe('ButtonAuthorizationComponent', () => {
  let component: ButtonAuthorizationComponent;
  let fixture: ComponentFixture<ButtonAuthorizationComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ButtonAuthorizationComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ButtonAuthorizationComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
