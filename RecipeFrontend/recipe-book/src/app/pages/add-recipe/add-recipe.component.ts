import { Component, Input, OnInit } from '@angular/core';
import { SPACE, ENTER } from '@angular/cdk/keycodes';
import { MatChipInputEvent } from '@angular/material/chips';
import { RecipeService } from 'src/app/services/recipe.service';
import { RecipeTag } from 'src/app/models/recipe-tag';
import { RecipeIngredientsBlock } from 'src/app/models/recipe-ingredients-block';
import { RecipeStep } from 'src/app/models/recipe-step';
import { Location } from '@angular/common';
import { ActivatedRoute } from '@angular/router';
import { UpdateRecipe } from 'src/app/models/update-recipe';
import { CreateRecipe } from 'src/app/models/create-recipe';

@Component({
  selector: 'app-add-recipe',
  templateUrl: './add-recipe.component.html',
  styleUrls: ['./add-recipe.component.css']
})

export class AddRecipeComponent implements OnInit {

  title!: string;
  description!: string;
  stepNumber: number = 1;
  steps: RecipeStep[] = [{number: this.stepNumber++, description: ''}];
  ingredientsId: number = 1;
  ingredientsBlocks: RecipeIngredientsBlock[] = [{name: '', recipeIngredients: ''}];
  tags: RecipeTag[] = [];

  cookingTime: number = 0;
  countPortion: number = 0;

  recipe: CreateRecipe = new CreateRecipe(
    this.title,
    this.description,
    this.cookingTime,
    this.countPortion,
    'string',
    this.ingredientsBlocks,
    this.steps,
    this.tags,
  );

  readonly idUpdateRecipe = parseInt(this.route.snapshot.paramMap.get('id')!, 10);

  pagesTitle!: string;
  btnText!: string;

  constructor(
    private recipeService: RecipeService,
    private location: Location,
    private route: ActivatedRoute,
  ) {}

  ngOnInit(): void {
    this.dropListContent();
    if (this.isUpdate()) {
      this.pagesTitle = 'Обновить рецепт';
      this.btnText = 'Обновить'
      this.getDetailedRecipe();
    } else {
      this.pagesTitle = 'Добавить новый рецепт';
      this.btnText = 'Опубликовать'
    }
  }

  isUpdate(): boolean {
    return !isNaN(this.idUpdateRecipe);
  }

  getDetailedRecipe(): void {
    this.recipeService.getUpdateDetailedRecipe(this.idUpdateRecipe)
      .subscribe(recipe => this.recipe = recipe);
  }

  visiblePortionsDropList: boolean = false;
  showPortionsDropList(): void {
    this.visiblePortionsDropList = !this.visiblePortionsDropList;
    let select = document.getElementsByClassName("select__header")[1]
    if (this.visiblePortionsDropList) {
      select.classList.add('select__header_focus');
    } else {
      select.classList.remove('select__header_focus');
    }
  }

  defoltMessageCountPortion: string = "Порций в блюде";

  choiceCountPortion(selectedCountPortion: number): void {
    this.recipe.portions = selectedCountPortion;
    this.showPortionsDropList();
  }

  visibleCookingTimeDropList: boolean = false;
  showCookingTimeDropList(): void {
    this.visibleCookingTimeDropList = !this.visibleCookingTimeDropList;
    let select = document.getElementsByClassName("select__header")[0]
    if (this.visibleCookingTimeDropList) {
      select.classList.add('select__header_focus');
    } else {
      select.classList.remove('select__header_focus');
    }
  }

  defoltMessageCookingTime: string = "Время готовки"

  choiceCookingTime(selectedCookingTime: number): void {
    this.recipe.cookingTime = selectedCookingTime;
    this.showCookingTimeDropList();
  }

  addStep(): void {
    this.recipe.recipeSteps.push({number: this.stepNumber++, description: ''});
  }

  deleteStep(number: number): void {
    if (this.recipe.recipeSteps.length !== 1) {
      this.recipe.recipeSteps = this.recipe.recipeSteps.filter(step => step.number != number);
      --this.stepNumber;
      this.recipe.recipeSteps.forEach(step => {
        if (step.number > number) {
          --step.number;
        }
      });
    }
  }

  addIngreidntsBlock(): void {
    this.ingredientsId++
    this.recipe.recipeIngredientsBlocks.push({name: '', recipeIngredients: ''});
  }

  deleteIngredientsBlock(): void {
    if (this.recipe.recipeIngredientsBlocks.length !== 1) {
      this.recipe.recipeIngredientsBlocks.splice(this.ingredientsId, 1);
      console.log(this.ingredientsId);
    }
  }

  cookTime: number[] = []
  countPortions: number[] = []
  dropListContent(): void {
    let i: number = 10
    for (i; i <= 120; i += 10) {
      this.cookTime.push(i);
    }
    for (i = 1; i <= 10; i += 1){
      this.countPortions.push(i);
    }
  }

  //................................................
  //..................ang material..................
  //................................................
  addOnBlur = false;
  readonly separatorKeysCodes = [ENTER, SPACE] as const;

  add(event: MatChipInputEvent): void {
    const value = (event.value || '').trim();

    // Add our tag
    if (value) {
      this.recipe.recipeTags.push({name: value});
    }

    // Clear the input value
    event.chipInput!.clear();
  }

  remove(tag: RecipeTag): void {
    const index = this.recipe.recipeTags.indexOf(tag);

    if (index >= 0) {
      this.recipe.recipeTags.splice(index, 1);
    }
  }
  //................................................
  //..................ang material..................
  //................................................

  goBack(): void {
    this.location.back();
  }

  addRecipe(title: string, description: string): void {
    title = title.trim();
    if (!title) { return; }
    description = description.trim();
    if (!description) { return }

    if (isNaN(this.idUpdateRecipe)) {
      this.recipeService.addRecipe( new CreateRecipe(
        title,
        description,
        this.recipe.cookingTime,
        this.recipe.portions,
        'string',
        this.recipe.recipeIngredientsBlocks,
        this.recipe.recipeSteps,
        this.recipe.recipeTags
      ))
        .subscribe(() => this.goBack());
    } else {
      this.recipeService.updateRecipe( new UpdateRecipe(
        this.idUpdateRecipe as number,
        title,
        description,
        this.recipe.cookingTime,
        this.recipe.portions,
        'string',
        this.recipe.recipeIngredientsBlocks,
        this.recipe.recipeSteps,
        this.recipe.recipeTags
      ))
        .subscribe(() => this.goBack());
    }
  }
}
