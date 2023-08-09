import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'appTeamInfo';
  milogo:string="https://th.bing.com/th/id/OIP.rZwmD67TdldWWlwN97fHDgHaEq?w=281&h=180&c=7&r=0&o=5&pid=1.7";
  rcblogo:string="https://th.bing.com/th/id/OIP.zhEkAftLdgCD1ttjCjsTNgHaHa?w=210&h=210&c=7&r=0&o=5&pid=1.7";
  dclogo:string="https://th.bing.com/th/id/OIP.uWWWNwQGr_swW7PHIdaWtAHaIh?w=139&h=180&c=7&r=0&o=5&pid=1.7";
  kkrlogo:string="https://th.bing.com/th/id/OIP._p-CBOMsow89_cOb6LSgVAHaHa?w=166&h=180&c=7&r=0&o=5&pid=1.7";
  csklogo:string="https://th.bing.com/th/id/OIP.mq9WR_9HGDykX4A_GqNN7QHaGH?w=202&h=180&c=7&r=0&o=5&pid=1.7";
  teams:any[] = [
    {
      tid:1, tname:'Mumbai Indians', temail:'support@mi.com', tslogan:'Duniya Hila Denge', 
      tlogo:this.milogo, ipltitle:5
    },
    {
      tid:2, tname:'Royal Challengers Banglore', temail:'support@rcb.com', 
      tslogan:'Ee Sala Cup Namde', tlogo:this.rcblogo, ipltitle:0
    },
    {
      tid:3, tname:'Delhi Captals', temail:'support@dc.com', tslogan:'Ye Haii Nai Delhi', 
      tlogo:this.dclogo, ipltitle:0
    },
    {
      tid:4, tname:'Kolkata Knight Riders', temail:'support@kkr.com', tslogan:'Korbo Lodbo Jitbo', 
      tlogo:this.kkrlogo, ipltitle:2
    },
    {
      tid:5, tname:'Chennai Super King', temail:'support@csk.com', tslogan:'Whistle Phodu', 
      tlogo:this.csklogo, ipltitle:5
    },
  ]
}
