export class RecipeOfDay {
  constructor(
    recipeId: number,
    title: string,
    description: string,
    image: string,
    cookingTime: number,
    recipeLikesCount: number,
  ){
    this.recipeId = recipeId
    this.title = title
    this.description = description
    this.image = image
    this.cookingTime = cookingTime
    this.recipeLikesCount = recipeLikesCount
  }
  recipeId: number
  title: string;
  description: string;
  image: string;
  cookingTime: number;
  recipeLikesCount: number;
}
