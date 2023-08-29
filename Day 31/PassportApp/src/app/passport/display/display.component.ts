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
  fillForm(selectedPP){
    this.objs.ppData = Object.assign({},selectedPP);
  }
  onDelete(pid){
    if(confirm('Are you sure you want to delete this passport?')){
      this.objs.delPassport(pid).subscribe(
        res=>{this.objs.getPassportList()},
        err=>(alert("Error Occured" + err))
      )
    }
  }
}
