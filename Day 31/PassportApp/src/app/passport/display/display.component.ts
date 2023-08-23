import { Component,OnInit } from '@angular/core';
import { PassportService } from 'src/app/shared/passport.service';

@Component({
  selector: 'app-display',
  templateUrl: './display.component.html',
  styleUrls: ['./display.component.css']
})
export class DisplayComponent implements OnInit {
  constructor(public objs:PassportService) {}

  ngOnInit():void{
    this.objs.getPassportList();
  }
}
