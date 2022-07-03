import { RecipeTag } from "./recipe-tag";

export class Recipe{
  constructor(
    recipeId: number,
    title: string,
    description: string,
    cookingTime: number,
    portions: number,
    image: string,
    recipeFavouritesCount: number,
    recipeLikesCount: number,
    recipeTags: Array<RecipeTag>,
  ){
    this.recipeId = recipeId
    this.title = title
    this.description = description
    this.cookingTime = cookingTime
    this.portions = portions
    this.image = image
    this.recipeFavouritesCount = recipeFavouritesCount
    this.recipeLikesCount = recipeLikesCount
    this.recipeTags = recipeTags
  }
  
  recipeId: number;
  title: string;
  description: string;
  cookingTime: number;
  portions: number;
  image: string;
  recipeFavouritesCount: number;
  recipeLikesCount: number;
  recipeTags: Array<RecipeTag>;
}
