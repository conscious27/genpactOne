import { Component } from '@angular/core';

@Component({
  selector: 'app-pipeex',
  templateUrl: './pipeex.component.html',
  styleUrls: ['./pipeex.component.css']
})
export class PipeexComponent {
  users:any[]=[
    {username:"Chaitanya", email:"cp@genpact.com", salary:12000, desig:"Developer"},
    {username:"Amit", email:"amit@genpact.com", salary:24000, desig:"Manager"},
    {username:"Aman", email:"aman@genpact.com", salary:36000, desig:"CTO"},
  ]
}
