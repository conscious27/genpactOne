import { Component } from '@angular/core';

@Component({
  selector: 'app-pipe',
  templateUrl: './pipe.component.html',
  styleUrls: ['./pipe.component.css']
})
export class PipeComponent {
  emps:any[]=[
    {eid:1, ename:'sam', esalary:98000.90, edoj:'12/21/2019'},
    {eid:2, ename:'ravi', esalary:75000.56, edoj:'11/22/2020'},
    {eid:3, ename:'arsh', esalary:75000.56, edoj:'10/22/2020'},
    {eid:4, ename:'raju', esalary:86000.56, edoj:'02/20/2023'},
    {eid:5, ename:'gagan', esalary:23000.56, edoj:'11/26/2021'}
  ]
}
