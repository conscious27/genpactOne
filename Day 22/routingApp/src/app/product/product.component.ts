import { Component } from '@angular/core';

@Component({
  selector: 'app-product',
  templateUrl: './product.component.html',
  styleUrls: ['./product.component.css']
})
export class ProductComponent {
  products:any[]=[
    {
      pid:1, price:1290, imgsrc:'assets/images/p1.jpg'
    },
    {
      pid:2, price:2878, imgsrc:'assets/images/p2.jpg'
    },
    {
      pid:3, price:6578, imgsrc:'assets/images/p3.jpg'
    },
  ]
}
