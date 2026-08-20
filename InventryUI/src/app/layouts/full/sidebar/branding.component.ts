import { Component } from '@angular/core';

@Component({
  selector: 'app-branding',
  template: `
    <div class="branding p-y-16 p-x-16 d-flex align-items-center">
      <a [routerLink]="['/dashboard']" class="d-flex align-items-center text-decoration-none">
        <img src="assets/images/logos/stockpilot-logo.svg" alt="StockPilot" style="height: 38px; width: auto;" />
      </a>
    </div>
  `,
})
export class BrandingComponent {
  constructor() {}
}
