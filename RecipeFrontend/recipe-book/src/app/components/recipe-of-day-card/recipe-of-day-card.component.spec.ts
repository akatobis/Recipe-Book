import { ComponentFixture, TestBed } from '@angular/core/testing';

import { RecipeOfDayCardComponent } from './recipe-of-day-card.component';

describe('RecipeOfDayCardComponent', () => {
  let component: RecipeOfDayCardComponent;
  let fixture: ComponentFixture<RecipeOfDayCardComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ RecipeOfDayCardComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(RecipeOfDayCardComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
