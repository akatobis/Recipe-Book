import { Component, OnInit } from '@angular/core';
import { RecipeOfDay } from 'src/app/models/recipe-of-day';
import { RecipeService } from 'src/app/services/recipe.service';

@Component({
  selector: 'app-main',
  templateUrl: './main.component.html',
  styleUrls: ['./main.component.css']
})
export class MainComponent implements OnInit {

  popupAddRecipe: boolean = false;
  popupSignUp: boolean = false;
  popupSignIn: boolean = false;
  linkAddRecipe: string = '/add-recipe';

  recipeOfDay!: RecipeOfDay;

  constructor(private recipeService: RecipeService) { }

  ngOnInit(): void {
    this.getRecipeOfDay();
  }

  asd(): void {
    console.log(this.recipeOfDay.recipeId);
  }

  getRecipeOfDay(): void {
    this.recipeService.getRecipeOfDay().subscribe(recipeOfDay => this.recipeOfDay = recipeOfDay)
  }

  showPopupAddRecipe(): void {
    this.popupAddRecipe = true;
  }

  closePopupAddRecipe(): void {
    this.popupAddRecipe = false;
  }

  showPopupSignUp(): void {
    this.popupSignUp = true;
    this.popupSignIn = false;
    this.popupAddRecipe = false;
  }

  closePopupSignUp(): void {
    this.popupSignUp = false;
  }

  showPopupSignIn(): void {
    this.popupSignIn = true;
    this.popupSignUp = false;
    this.popupAddRecipe = false;
  }

  closePopupSignIn(): void {
    this.popupSignIn = false;
  }

}
