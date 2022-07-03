import { Component, OnInit, Input } from '@angular/core';
import { RecipeIngredientsBlock } from 'src/app/models/recipe-ingredients-block';
import { RecipeStep } from 'src/app/models/recipe-step';
import { RecipeTag } from 'src/app/models/recipe-tag';

@Component({
  selector: 'app-recipe-card',
  templateUrl: './recipe-card.component.html',
  styleUrls: ['./recipe-card.component.css']
})
export class RecipeCardComponent implements OnInit {

  constructor() {}

  ngOnInit(): void {
  }

  @Input() title: string = '';
  @Input() description: string = '';
  @Input() cookingTime: number = 0;
  @Input() portions: number = 0;
  @Input() image: string = '';
  @Input() recipeFavouritesCount: number = 0;
  @Input() recipeLikesCount: number = 0;
  @Input() recipeTags!: Array<RecipeTag>;

}
