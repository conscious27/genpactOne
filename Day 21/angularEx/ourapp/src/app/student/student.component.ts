import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-student',
  templateUrl: './student.component.html',
  styleUrls: ['./student.component.css']
})
export class StudentComponent implements OnInit {

  constructor() {}

  ngOnInit():void {
  }

  students:any[]=[
    {sid:1, sname:"sam", sFee:5000.89, sdob:'12/12/2012'},
    {sid:2, sname:"raj", sFee:5000.89, sdob:'12/12/2012'},
    {sid:3, sname:"amit", sFee:3000.89, sdob:'04/24/2012'},
    {sid:4, sname:"nitin", sFee:4000.89, sdob:'12/11/2012'},
    {sid:5, sname:"ruhi", sFee:2500.89, sdob:'12/09/2012'},
    {sid:6, sname:"juhi", sFee:5000.89, sdob:'02/12/2012'}
  ];
}
