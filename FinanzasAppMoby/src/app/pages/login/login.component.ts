import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, NgForm, Validators } from '@angular/forms';
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

    //se agregan validaciones para la ruta login
    this.form=this.formBuilder.group({
      accesEmail:['',[Validators.required,Validators.email]],
      accesPass:['',[Validators.required,Validators.minLength(8)]]
    })
  }

  get accesEmail():any
  {
    return this.form.get("accesEmail");
  }
  get accesPass():any
  {
    return this.form.get("accesPass");
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
      let login:LoginStar=new LoginStar(accesPass,accesEmail) 
      this.myService.starSession(login).subscribe({
         next:(data) =>{
          console.log(data);
          // esta entrando siempre y cuando el service recibe data.
          // revisar desde el back encasa de estar autentificado enviar data, si no enviar respueta vacia
          if (data != null)
          {
            this.form.reset;
            this.route.navigate(['/home'])  
          }
          else 
          {
            alert("wrong password or username")
          }
           
         },
        

      });

 
    }
    else
    {
      alert("Some of the entered values are incorrect");
      this.form.markAllAsTouched();
    }
    this.form.reset();
  } 

  
  } 


