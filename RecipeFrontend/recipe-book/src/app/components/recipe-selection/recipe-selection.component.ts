import { Component, OnInit, Input } from '@angular/core';

@Component({
  selector: 'app-recipe-selection',
  templateUrl: './recipe-selection.component.html',
  styleUrls: ['./recipe-selection.component.css']
})
export class RecipeSelectionComponent implements OnInit {

  @Input() icon?: 'book' | 'omelet' | 'chef' | 'carrot';
  @Input() title: string = '';
  @Input() text: string = '';

  constructor() { }

  ngOnInit(): void {
  }

}
