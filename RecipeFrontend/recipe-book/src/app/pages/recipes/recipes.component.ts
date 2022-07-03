import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { Recipe } from 'src/app/models/recipe';

import { RecipeService } from 'src/app/services/recipe.service';

@Component({
  selector: 'app-recipes',
  templateUrl: './recipes.component.html',
  styleUrls: ['./recipes.component.css']
})
export class RecipesComponent implements OnInit {

  recipes: Recipe[] = [];
  skip: number = 0;
  prevSearch: string = '';
  currSearch: string = '';
  firstSearch: boolean = true;

  constructor(private recipeService: RecipeService, private route: ActivatedRoute) { }

  searchMain = this.route.snapshot.queryParamMap.get('search');
  serchMain: string = '';

  ngOnInit(): void {
    if (this.searchMain === null) {
      this.onSearchRecipe('');
    } else {
      this.onSearchRecipe(this.searchMain);
    }
  }

  downloadRecipes(): void {
    this.skip += 5;
    this.onSearchRecipe(this.currSearch);
  }

  onSearchRecipe(search: string): void {
    this.currSearch = search;
    if (this.currSearch !== this.prevSearch) {
      this.prevSearch = this.currSearch;
      this.skip = 0;
      this.recipes = [];
    }
    this.recipeService.getRecipes(this.skip, search as string).subscribe(recipes => recipes.forEach(element => {
      this.recipes.push(element)
    }));
  }

}
