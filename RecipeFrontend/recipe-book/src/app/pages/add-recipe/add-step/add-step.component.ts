import { Component, Input, OnInit, Output, EventEmitter } from '@angular/core';
import { RecipeStep } from 'src/app/models/recipe-step';

@Component({
  selector: 'app-add-step',
  templateUrl: './add-step.component.html',
  styleUrls: ['./add-step.component.css']
})
export class AddStepComponent implements OnInit {

  constructor() { }

  ngOnInit(): void {
  }

  @Input() stepNumber!: number;
  @Output() onDeleteStep = new EventEmitter;
  @Output() recipeStep: RecipeStep = {number: this.stepNumber, description: ''};

  delete(): void {
    if (this.stepNumber != 1) {
      this.onDeleteStep.emit(this.stepNumber as number);
    }
  }

}
