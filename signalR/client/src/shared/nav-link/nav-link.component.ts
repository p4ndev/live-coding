import { Component, Input } from '@angular/core';

@Component({
  selector:     'app-nav-link',
  templateUrl:  './nav-link.component.html',
  styleUrls:    ['./nav-link.component.sass']
})
export class NavLinkComponent {
  @Input("to") href? : string;
}
