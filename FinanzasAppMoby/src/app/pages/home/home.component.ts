import { Component, OnInit } from '@angular/core';
import { FormArray, FormControl, FormGroup, Validators } from '@angular/forms';
import { ValueFromArray } from 'rxjs';
import { ProfileService } from 'src/app/service/profile.service';


@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {

  profile:any;

  public formParent: FormGroup= new FormGroup({});

  constructor(private miServicio:ProfileService) { }

  ngOnInit(): void {
    this.miServicio.getProfile().subscribe(data => {
      console.log(data);
      this.profile=data;
    })

  }
  initFormParent(): void
  {
    this.formParent = new FormGroup(
      {
        name: new FormControl('', [Validators.required, Validators.minLength(5)]),
        expenses: new FormArray([], [Validators.required])
      }
    )
  }

  //form hijo retorna un grupo 
  initFormExpenses(): FormGroup{
    return new FormGroup(
      {
        expenses: new FormControl(''),
        description: new FormControl(''),
      }
    )
  }

  //agregar nuevo gasto
  addExpenses(): void{
    const refExpenses = this.formParent.get('expenses') as FormArray;
    refExpenses.push(this.initFormExpenses())
  }

  //obtener referencia formcontrol
  getCtrl(key:string, form: FormGroup): any{
    return form.get(key)
  }
}
