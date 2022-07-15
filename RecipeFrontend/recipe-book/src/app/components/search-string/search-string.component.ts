import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { Router } from '@angular/router';
import { FormControl } from '@angular/forms';

@Component({
  selector: 'app-search-string',
  templateUrl: './search-string.component.html',
  styleUrls: ['./search-string.component.css']
})
export class SearchStringComponent implements OnInit {

  constructor(private router: Router) { }

  ngOnInit(): void {
  }

  @Input() searchString: string | null = '';

  @Output() onSearch = new EventEmitter();

  searchRecipe(): void {
    this.onSearch.emit(this.searchString);
  }

  reDirect(searchValue: string): void {
    this.router.navigate(['/recipes'], {queryParams: {search: searchValue}})
  }
}
