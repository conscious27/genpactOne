import { Component } from '@angular/core';

@Component({
  selector: 'app-animals',
  templateUrl: './animals.component.html',
  styleUrls: ['./animals.component.css']
})
export class AnimalsComponent {
  animals:any[]=[
    {aname:'Tiger', species:'Feline', photos:'https://th.bing.com/th/id/OIP.jF-kCTt5tK99_v5uiStPAAHaFj?w=252&h=189&c=7&r=0&o=5&pid=1.7'},
    {aname:'Parrot', species:'Bird', photos:'https://th.bing.com/th/id/OIP.qCbJl0cMcZu8wcPfmg7QnQHaE7?w=238&h=180&c=7&r=0&o=5&pid=1.7'},
    {aname:'Finray', species:'Fish', photos:'https://th.bing.com/th/id/OIP.iNkAKTBZPaGAWTrZKTBGEAHaFQ?w=278&h=197&c=7&r=0&o=5&pid=1.7'}
  ]
}
