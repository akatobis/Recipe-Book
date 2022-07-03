import { Component, Input, OnInit, Output, EventEmitter } from '@angular/core';
import { RecipeIngredientsBlock } from 'src/app/models/recipe-ingredients-block';

@Component({
  selector: 'app-add-ingedients',
  templateUrl: './add-ingedients.component.html',
  styleUrls: ['./add-ingedients.component.css']
})
export class AddIngedientsComponent implements OnInit {

  constructor() { }

  ngOnInit(): void {
  }

  @Input() ingredientBlock!: RecipeIngredientsBlock;

  @Output() onDeleteIngredientsBlock = new EventEmitter();

  delete(): void {
    console.log(this.ingredientBlock);
    this.onDeleteIngredientsBlock.emit(this.ingredientBlock);
  }

}
