import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-custompipe',
  templateUrl: './custompipe.component.html',
  styleUrls: ['./custompipe.component.css']
})
export class CustompipeComponent implements OnInit{
  constructor() {}

  ngOnInit(): void {
    
  }
  // side:number=5;
  img1Size=1024;
  img2Size=4096;
  file1Size=2048;
  fil2Size=3000;
  db1Size=1024;
  db2Size=2050;
  username:string="Arushi";
}
