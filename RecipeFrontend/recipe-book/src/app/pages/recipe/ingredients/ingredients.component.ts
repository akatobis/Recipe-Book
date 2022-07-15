import { Component, Input, OnInit } from '@angular/core';
import { RecipeIngredientsBlock } from 'src/app/models/recipe-ingredients-block';

@Component({
  selector: 'app-ingredients',
  templateUrl: './ingredients.component.html',
  styleUrls: ['./ingredients.component.css']
})
export class IngredientsComponent implements OnInit {

  constructor() { }

  ngOnInit(): void {
  }

  @Input() recipeIngredientsBlock!: RecipeIngredientsBlock;

}
