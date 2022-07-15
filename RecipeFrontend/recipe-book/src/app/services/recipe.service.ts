import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders, HttpParams } from '@angular/common/http';
import { DetailedRecipe } from '../models/deteiled-recipe';
import { Observable } from 'rxjs';
import { Recipe } from '../models/recipe';
import { PreloaderService } from './preloader.service';
import { finalize } from "rxjs/operators";
import { RecipeOfDay } from '../models/recipe-of-day';
import { UpdateRecipe } from '../models/update-recipe';
import { CreateRecipe } from '../models/create-recipe';

@Injectable({
  providedIn: 'root'
})
export class RecipeService {

  constructor(
    private http: HttpClient,
    private preloaderService: PreloaderService) { }

  httpOptions = {
    headers: new HttpHeaders({ 'Content-Type': 'application/json' })
  };

  getDetailedRecipe(id: number): Observable<DetailedRecipe> {
    this.requestInterceptor();
    const url = `api/recipe/${id}`;
    return this.http.get<DetailedRecipe>(url).pipe(
      finalize(() => {
              this.onFinally();
            })
    )
  }

  getUpdateDetailedRecipe(id: number): Observable<DetailedRecipe> {
    this.requestInterceptor();
    const url = `api/add-recipe/${id}`;
    return this.http.get<DetailedRecipe>(url).pipe(
      finalize(() => {
              this.onFinally();
            })
    )
  }

  getRecipes(skip: number, search: string): Observable<Recipe[]>{
    this.requestInterceptor();
    const params = new HttpParams()
      .set('skip', skip.toString())
      .set('search', search.toString());
    const url = `api/recipes`;
    return this.http.get<Recipe[]>(url, {params}).pipe(
      finalize(() => {
              this.onFinally();
            })
    )
  }

  getRecipeOfDay(): Observable<RecipeOfDay> {
    this.requestInterceptor();
    const url = `api/main`;
    return this.http.get<RecipeOfDay>(url).pipe(
      finalize(() => {
              this.onFinally();
            })
    )
  }

  addRecipe(recipe: CreateRecipe): Observable<CreateRecipe> {
    this.requestInterceptor();
    const url = `api/add-recipe`;
    return this.http.post<CreateRecipe>(url, recipe, this.httpOptions).pipe(
      finalize(() => {
              this.onFinally();
            })
    )
  }

  updateRecipe(recipe: UpdateRecipe): Observable<any> {
    this.requestInterceptor();
    const url = `api/add-recipe/${recipe.recipeId}`;
    return this.http.put(url, recipe, this.httpOptions).pipe(
      finalize(() => {
              this.onFinally();
            })
    );
  }

  deleteRecipe(id: number): Observable<DetailedRecipe> {
    this.requestInterceptor();
    const url = `api/recipe/${id}`;
    return this.http.delete<DetailedRecipe>(url, this.httpOptions).pipe(
      finalize(() => {
              this.onFinally();
            })
    )
  }

  private requestInterceptor(): void {
    this.preloaderService.showPreloader();
  }

  private responseInterceptor(): void {
    this.preloaderService.hidePreloader();
  }

  private onFinally(): void {
    this.responseInterceptor();
  }

}
