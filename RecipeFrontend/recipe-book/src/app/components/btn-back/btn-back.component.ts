import { Component, OnInit } from '@angular/core';
import { Location } from '@angular/common';

@Component({
  selector: 'app-btn-back',
  templateUrl: './btn-back.component.html',
  styleUrls: ['./btn-back.component.css']
})
export class BtnBackComponent implements OnInit {

  goBack(): void {
    this.location.back();
  }

  constructor(private location: Location) { }

  ngOnInit(): void {
  }

}
