import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  username:"Sam1256" = "Sam1256";
  imgPath : string="https://openclipart.org/image/2400px/svg_to_png/272339/angular.png";
  isDis: boolean=false;
  welcome()
{
  alert('Welcome to Angular');
}

fname:string="sam";
lname:String="Dicosta";
}


