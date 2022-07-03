import { ComponentFixture, TestBed } from '@angular/core/testing';

import { PopupAddRecipeComponent } from './popup-add-recipe.component';

describe('PopupAddRecipeComponent', () => {
  let component: PopupAddRecipeComponent;
  let fixture: ComponentFixture<PopupAddRecipeComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ PopupAddRecipeComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(PopupAddRecipeComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
