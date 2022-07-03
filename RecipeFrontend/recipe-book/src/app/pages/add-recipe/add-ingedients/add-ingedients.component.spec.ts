import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AddIngedientsComponent } from './add-ingedients.component';

describe('AddIngedientsComponent', () => {
  let component: AddIngedientsComponent;
  let fixture: ComponentFixture<AddIngedientsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ AddIngedientsComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(AddIngedientsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
