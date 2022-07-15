import { Component, EventEmitter, OnInit, Output } from '@angular/core';
import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormControl, FormGroup, ReactiveFormsModule } from '@angular/forms';

@Component({
  selector: 'app-popup-sign-in',
  templateUrl: './popup-sign-in.component.html',
  styleUrls: ['./popup-sign-in.component.css']
})
export class PopupSignInComponent implements OnInit {

  @Output() onClosePopup = new EventEmitter();
  @Output() onShowPopupSignUp = new EventEmitter();

  // formSignIn!: FormGroup;

  constructor() { }

  ngOnInit(): void {
  }

  formSignIn = new FormGroup({
    login: new FormControl(''),
    password: new FormControl(''),
  })

  signIn(): void {

  }

  showPopupSignUp(): void {
    this.onShowPopupSignUp.emit();
  }

  close(): void {
    this.onClosePopup.emit()
  }

}
