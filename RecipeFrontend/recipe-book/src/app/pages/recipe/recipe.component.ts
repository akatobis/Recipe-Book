import { Component, OnInit } from '@angular/core';
import { DetailedRecipe } from 'src/app/models/deteiled-recipe';
import { RecipeService } from 'src/app/services/recipe.service';
import { Location } from '@angular/common';

import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-recipe',
  templateUrl: './recipe.component.html',
  styleUrls: ['./recipe.component.css']
})
export class RecipeComponent implements OnInit {

  recipe!: DetailedRecipe;
  readonly id = parseInt(this.route.snapshot.paramMap.get('id')!, 10);

  constructor(
    private recipeService: RecipeService,
    private route: ActivatedRoute,
    private location: Location,
  ) { }

  ngOnInit(): void {
    this.getDetailedRecipe();
  }

  getDetailedRecipe(): void {
    this.recipeService.getDetailedRecipe(this.id)
      .subscribe(recipe => this.recipe = recipe);
  }

  goBack(): void {
    this.location.back();
  }

  deleteRecipe(): void {
    this.recipeService.deleteRecipe(this.id).subscribe(() => this.goBack());
  }
}
