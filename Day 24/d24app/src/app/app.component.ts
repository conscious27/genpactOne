import { Component, OnInit } from '@angular/core';
import { ContactService } from './contact.service';
import { Validators, FormBuilder, FormGroup, Form } from '@angular/forms';
import { formatNumber } from '@angular/common';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit{
  contactForm:FormGroup | undefined;
  submittedData:any[]=[];
  constructor(private frmBuilder:FormBuilder)
  {}

    ngOnInit(): void {
      this.contactForm = this.frmBuilder.group
      ({
        name:['',Validators.required],
        email:['',[Validators.required, Validators.email]],
        message:['',Validators.required],
      });
    }

    OnSubmit(){
      if(this.contactForm?.valid)
      {
        const formData=this.contactForm.value;
        this.submittedData.push(formData);
        this.contactForm.reset();
        alert('Form Submitted' + formData);
      }
      else{
        alert('Form is Invalid')
      }
    }
}
