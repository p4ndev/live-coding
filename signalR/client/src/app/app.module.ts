import { NavLinkComponent }             from 'src/shared/nav-link/nav-link.component';
import { DemoServices }                 from 'src/shared/services/demo.services';
import { BrowserModule }                from '@angular/platform-browser';
import { AppRoutingModule }             from './app-routing.module';
import { AppComponent }                 from './app.component';
import { APP_INITIALIZER, NgModule }    from '@angular/core';
import { CommonModule }                 from '@angular/common';

import {
  BackupComponent, ChatComponent, HomeComponent
}                                       from 'src/pages';

@NgModule({
  declarations: [
    AppComponent,
    NavLinkComponent,
    HomeComponent,
    ChatComponent,
    BackupComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    CommonModule
  ],
  providers: [
    DemoServices,
    {
      provide:    APP_INITIALIZER,
      useFactory: (_ : DemoServices) => () => _.Init(),
      deps:       [ DemoServices ],
      multi:      true
    }
  ],
  bootstrap: [ AppComponent ]
})
export class AppModule { }
