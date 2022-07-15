import { RecipeIngredientsBlock } from "./recipe-ingredients-block";
import { RecipeStep } from "./recipe-step";
import { RecipeTag } from "./recipe-tag";

export class UpdateRecipe {
  constructor(
    recipeId: number,
    title: string,
    description: string,
    cookingTime: number,
    portions: number,
    image: string,
    recipeIngredientsBlocks: Array<RecipeIngredientsBlock>,
    recipeSteps: Array<RecipeStep>,
    recipeTags: Array<RecipeTag>,
  ){
    this.recipeId = recipeId
    this.title = title
    this.description = description
    this.cookingTime = cookingTime
    this.portions = portions
    this.image = image
    this.recipeIngredientsBlocks = recipeIngredientsBlocks
    this.recipeSteps = recipeSteps
    this.recipeTags = recipeTags
  }

  recipeId: number;
  title: string;
  description: string;
  cookingTime: number;
  portions: number;
  image: string;
  recipeIngredientsBlocks: Array<RecipeIngredientsBlock>;
  recipeSteps: Array<RecipeStep>;
  recipeTags: Array<RecipeTag>;
}
