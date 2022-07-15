import { Component, Input, OnInit } from '@angular/core';
import { RecipeStep } from 'src/app/models/recipe-step';

@Component({
  selector: 'app-step',
  templateUrl: './step.component.html',
  styleUrls: ['./step.component.css']
})
export class StepComponent implements OnInit {

  constructor() { }

  ngOnInit(): void {
  }

  @Input() recipeStep!: RecipeStep;

}
