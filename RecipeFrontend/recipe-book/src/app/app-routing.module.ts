import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AddRecipeComponent } from './pages/add-recipe/add-recipe.component';
import { FavouritesComponent } from './pages/favourites/favourites.component';
import { MainComponent } from './pages/main/main.component';
import { RecipesComponent } from './pages/recipes/recipes.component';
import { RecipeComponent } from './pages/recipe/recipe.component';
import { MyProfileComponent } from './pages/my-profile/my-profile.component';

const routes: Routes = [
  { path: '', redirectTo: '/main', pathMatch: 'full' },
  { path: 'main', component: MainComponent },
  { path: 'recipes', component: RecipesComponent },
  { path: 'recipes/:search', component: RecipesComponent },
  { path: 'favourites', component: FavouritesComponent },
  { path: 'add-recipe', component: AddRecipeComponent },
  { path: 'add-recipe/:id', component: AddRecipeComponent },
  { path: 'recipe/:id', component: RecipeComponent },
  { path: 'my-profile', component: MyProfileComponent },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
