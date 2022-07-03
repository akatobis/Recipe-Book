import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-header',
  templateUrl: './header.component.html',
  styleUrls: ['./header.component.css']
})
export class HeaderComponent implements OnInit {

  lincs = document.getElementsByClassName("navigation__item")
  lincMain = this.lincs[0];
  lincRecipe = this.lincs[1];
  lincFavourite = this.lincs[2]

  constructor() { }

  ngOnInit(): void {
    this.active();
  }

  active(): void {
    let route = window.location.pathname;
    let lincs = document.getElementsByClassName("navigation__item")
    let lincMain = this.lincs[0];
    let lincRecipe = this.lincs[1];
    let lincFavourite = this.lincs[2]
    console.log(route);
    if (route === '/main') {
      lincMain.classList.add('navigation__item_active');
      lincFavourite.classList.remove('navigation__item_active');
      lincRecipe.classList.remove('navigation__item_active');
    } else if (route === '/favourites') {
      lincFavourite.classList.add('navigation__item_active');
      lincMain.classList.remove('navigation__item_active');
      lincRecipe.classList.remove('navigation__item_active');
    } else {
      lincRecipe.classList.add('navigation__item_active');
      lincFavourite.classList.remove('navigation__item_active');
      lincMain.classList.remove('navigation__item_active');
    }
  }

}
