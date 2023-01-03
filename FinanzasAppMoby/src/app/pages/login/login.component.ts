import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { LoginStar } from 'src/app/Models/loginStar';
import { LoginService } from 'src/app/service/login/login.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {
  form:FormGroup;
 


  constructor(private formBuilder:FormBuilder,private myService:LoginService,private route:Router) { 
    this.form=this.formBuilder.group({
      email:['',[Validators.required,Validators.email]],
      pass:['',[Validators.required,Validators.minLength(8)]],
      accesEmail:['',[Validators.required,Validators.email]],
      accesPass:['',[Validators.required,Validators.minLength(8)]]
    })
  }

  get accesEmail():any
  {
    return this.form.get("accesEmail");
  }
  get Email()
  {
    return this.form.get("Email");
  }
  get accesPass():any
  {
    return this.form.get("accesPass");
  }
  get Pass()
  {
    return this.form.get("Pass");
  }


  ngOnInit(): void {
  }

  login()
  {
    
    if(this.form.valid)
    { 
      //recupero los datos ingresados en el formulario 
      let accesEmail:string=this.form.get('accesEmail')?.value;
      let accesPass:string=this.form.get('accesPass')?.value; 
      //Ingreso los valores en el login y el login en el metodo starSession
      let login:LoginStar=new LoginStar(accesEmail,accesPass) 
      this.myService.starSession(login).subscribe(respuestaOk=>{
        document.getElementById("gobutton")?.click(); 
        this.route.navigate(['/home'])
      });
     
      
    }
    else
    {
      alert("Some of the entered values ​​are incorrect");
      this.form.markAllAsTouched();
    }
    //Llamada al servicio y envio de datos al Login
    this.form.reset();
  } 

}
