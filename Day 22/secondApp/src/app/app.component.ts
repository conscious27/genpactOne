import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  emps:any[]=[
    {
      id:1,name:'sam',salary:98000.90,desig:'Manager',doj:'09/23/2012'
    },
    {
      id:1,name:'raj',salary:98000.90,desig:'developer',doj:'12/09/2012'
    },    
    {
      id:1,name:'ravi',salary:98000.90,desig:'tester',doj:'12/08/2012'
    },    
    {
      id:1,name:'nitin',salary:98000.90,desig:'developer',doj:'12/07/2012'
    },    
    {
      id:1,name:'vijay',salary:98000.90,desig:'tester',doj:'12/06/2012'
    }
  ]
}
