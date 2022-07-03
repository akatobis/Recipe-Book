import { Component, EventEmitter, OnInit, Output } from '@angular/core';

@Component({
  selector: 'app-popup-sign-up',
  templateUrl: './popup-sign-up.component.html',
  styleUrls: ['./popup-sign-up.component.css']
})
export class PopupSignUpComponent implements OnInit {

  @Output() onClosePopup = new EventEmitter();
  @Output() onShowPopupSignIn = new EventEmitter();

  constructor() { }

  ngOnInit(): void {
  }

  showPopupSignIn(): void {
    this.onShowPopupSignIn.emit();
  }

  close(): void {
    this.onClosePopup.emit()
  }

}
