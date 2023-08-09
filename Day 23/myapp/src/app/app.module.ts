import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { CustompipeComponent } from './custompipe/custompipe.component';
import { HomeComponent } from './home/home.component';
import { NavComponent } from './nav/nav.component';
import { PipeComponent } from './pipe/pipe.component';
import { SquarePipe } from './square.pipe';
import { BconvertorPipe } from './bconvertor.pipe';
import { WelcomePipe } from './welcome.pipe';

@NgModule({
  declarations: [
    AppComponent,
    CustompipeComponent,
    HomeComponent,
    NavComponent,
    PipeComponent,
    SquarePipe,
    BconvertorPipe,
    WelcomePipe
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
