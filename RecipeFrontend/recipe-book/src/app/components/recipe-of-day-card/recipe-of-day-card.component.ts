import { Component, Input, OnInit } from '@angular/core';

@Component({
  selector: 'app-recipe-of-day-card',
  templateUrl: './recipe-of-day-card.component.html',
  styleUrls: ['./recipe-of-day-card.component.css']
})
export class RecipeOfDayCardComponent implements OnInit {

  @Input() title: string = '';
  @Input() description: string = '';
  @Input() image: string = '';
  @Input() cookingTime: number = 0;
  @Input() recipeLikesCount: number = 0;

  constructor() { }

  ngOnInit(): void {
  }

}
