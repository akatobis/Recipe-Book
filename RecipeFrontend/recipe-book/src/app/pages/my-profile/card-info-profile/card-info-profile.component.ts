import { Component, Input, OnInit } from '@angular/core';

@Component({
  selector: 'app-card-info-profile',
  templateUrl: './card-info-profile.component.html',
  styleUrls: ['./card-info-profile.component.css']
})
export class CardInfoProfileComponent implements OnInit {

  constructor() { }

  ngOnInit(): void {
  }

  @Input() text!: string;
  @Input() count!: number;

}
