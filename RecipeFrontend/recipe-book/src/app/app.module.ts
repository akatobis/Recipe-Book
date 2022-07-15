import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule } from '@angular/common/http';
import { MatIconModule } from '@angular/material/icon';
import { MatChipsModule } from '@angular/material/chips';
import { MatFormFieldModule } from '@angular/material/form-field';
import { FormsModule } from '@angular/forms';
import { ReactiveFormsModule } from '@angular/forms';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HeaderComponent } from './components/header/header.component';
import { ButtonAuthorizationComponent } from './components/header/button-authorization/button-authorization.component';
import { SearchStringComponent } from './components/search-string/search-string.component';
import { FooterComponent } from './components/footer/footer.component';
import { MainComponent } from './pages/main/main.component';
import { AddRecipeComponent } from './pages/add-recipe/add-recipe.component';
import { FavouritesComponent } from './pages/favourites/favourites.component';
import { RecipeSelectionComponent } from './components/recipe-selection/recipe-selection.component';
import { RecipeCardComponent } from './components/recipe-card/recipe-card.component';
import { RecipesComponent } from './pages/recipes/recipes.component';
import { RecipeComponent } from './pages/recipe/recipe.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { BtnBackComponent } from './components/btn-back/btn-back.component';
import { IngredientsComponent } from './pages/recipe/ingredients/ingredients.component';
import { StepComponent } from './pages/recipe/step/step.component';
import { AddStepComponent } from './pages/add-recipe/add-step/add-step.component';
import { AddIngedientsComponent } from './pages/add-recipe/add-ingedients/add-ingedients.component';
import { PopupAddRecipeComponent } from './components/popup-add-recipe/popup-add-recipe.component';
import { MyProfileComponent } from './pages/my-profile/my-profile.component';
import { CardInfoProfileComponent } from './pages/my-profile/card-info-profile/card-info-profile.component';
import { PreloaderComponent } from './components/preloader/preloader.component';
import { PopupSignUpComponent } from './components/popup-sign-up/popup-sign-up.component';
import { PopupSignInComponent } from './components/popup-sign-in/popup-sign-in.component';
import { RecipeOfDayCardComponent } from './components/recipe-of-day-card/recipe-of-day-card.component';

@NgModule({
  declarations: [
    AppComponent,
    HeaderComponent,
    ButtonAuthorizationComponent,
    SearchStringComponent,
    FooterComponent,
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
    AddStepComponent,
    AddIngedientsComponent,
    PopupAddRecipeComponent,
    MyProfileComponent,
    CardInfoProfileComponent,
    PreloaderComponent,
    PopupSignUpComponent,
    PopupSignInComponent,
    RecipeOfDayCardComponent,
  ],
  imports: [
    FormsModule,
    ReactiveFormsModule,
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
