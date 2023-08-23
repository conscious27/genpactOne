import { Component, OnInit } from '@angular/core';
import { PassportService } from 'src/app/shared/passport.service';
import { NgForm } from '@angular/forms';

@Component({
  selector: 'app-reg',
  templateUrl: './reg.component.html',
  styleUrls: ['./reg.component.css']
})
export class RegComponent implements OnInit{
  constructor(public objService:PassportService){}
  ngOnInit(): void {
    this.resetForm();
  }

  resetForm(form?:NgForm)
  {
    if(form!=null){
      form.form.reset();
    }
    else{
      this.objService.ppData={Id:0,HolderName:'',PassportNumber:'',Expiry:'',POCode:''}
    }
  }
  onSubmit(form:NgForm)
  {
    if(this.objService.ppData.Id=0){
      this.insertRecord(form);
    }
    else{
      this.updateRecord(form);
    }
  }
  insertRecord(form:NgForm){
    this.objService.postPassport().subscribe(res=>
      {this.resetForm(form);
      this.objService.getPassportList();
      alert('Passport Registration Success!!');
    },
    err=>{alert('Error!!!'+err);})
  }
  updateRecord(form:NgForm)
  {
    this.objService.putPassport().subscribe(
      res=>{
        this.resetForm();
        this.objService.getPassportList();
        alert('Passport Record Updated');
      },
      err=>{
        alert('Error!'+err);
      }
    )
  }
}
