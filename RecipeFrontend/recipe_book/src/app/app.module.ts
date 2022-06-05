import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule } from '@angular/common/http';
import {MatIconModule} from '@angular/material/icon';
import {MatChipsModule} from '@angular/material/chips';
import {MatFormFieldModule} from '@angular/material/form-field';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HeaderComponent } from './header/header.component';
import { ButtonAuthorizationComponent } from './header/button-authorization/button-authorization.component';
import { SearchStringComponent } from './search-string/search-string.component';
import { FooterComponent } from './footer/footer.component';
import { ButtonSearchComponent } from './search-string/button-search/button-search.component';
import { MainComponent } from './main/main.component';
import { AddRecipeComponent } from './add-recipe/add-recipe.component';
import { FavouritesComponent } from './favourites/favourites.component';
import { RecipeSelectionComponent } from './recipe-selection/recipe-selection.component';
import { RecipeCardComponent } from './recipe-card/recipe-card.component';
import { RecipesComponent } from './recipes/recipes.component';
import { RecipeComponent } from './recipe/recipe.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { BtnBackComponent } from './btn-back/btn-back.component';
import { IngredientsComponent } from './recipe/ingredients/ingredients.component';
import { StepComponent } from './recipe/step/step.component';

@NgModule({
  declarations: [
    AppComponent,
    HeaderComponent,
    ButtonAuthorizationComponent,
    SearchStringComponent,
    FooterComponent,
    ButtonSearchComponent,
    MainComponent,
    AddRecipeComponent,
    RecipesComponent,
    FavouritesComponent,
    RecipeSelectionComponent,
    RecipeCardComponent,
    RecipesComponent,
    RecipeComponent,
    BtnBackComponent,
    IngredientsComponent,
    StepComponent,
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    BrowserAnimationsModule,
    MatChipsModule,
    MatFormFieldModule,
    MatIconModule,
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
