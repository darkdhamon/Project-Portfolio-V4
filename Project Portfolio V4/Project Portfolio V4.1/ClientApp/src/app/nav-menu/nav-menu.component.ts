import { Component } from '@angular/core';

@Component({
  selector: 'app-nav-menu',
  templateUrl: './nav-menu.component.html',
  styleUrls: ['./nav-menu.component.css']
})
export class NavMenuComponent {
  isExpanded = false;
  menus = [
    {
      active: true,
      route: "/",
      name: "Home"
    },
    {
      active: true,
      route: "/counter",
      name: "Counter"
    },
    {
      active: true,
      route: "/fetch-data",
      name: "Fetch data"
    }
  ];

  constructor(

  ) {
    
  }

  collapse() {
    this.isExpanded = false;
  }

  toggle() {
    this.isExpanded = !this.isExpanded;
  }
}
