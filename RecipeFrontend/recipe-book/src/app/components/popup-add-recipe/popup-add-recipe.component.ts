import { Component, EventEmitter, OnInit, Output } from '@angular/core';

@Component({
  selector: 'app-popup-add-recipe',
  templateUrl: './popup-add-recipe.component.html',
  styleUrls: ['./popup-add-recipe.component.css']
})
export class PopupAddRecipeComponent implements OnInit {

  @Output() onClosePopup = new EventEmitter();
  @Output() onShowPopupSignIn = new EventEmitter();
  @Output() onShowPopupSignUp = new EventEmitter();

  constructor() { }

  ngOnInit(): void {
  }

  showPopupSignIn(): void {
    this.onShowPopupSignIn.emit();
  }

  showPopupSignUp(): void {
    this.onShowPopupSignUp.emit();
  }

  close(): void {
    this.onClosePopup.emit();
  }

}
