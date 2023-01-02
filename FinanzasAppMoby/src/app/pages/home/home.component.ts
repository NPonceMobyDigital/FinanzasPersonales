import { Component, OnInit } from '@angular/core';
import { ProfileService } from 'src/app/service/profile.service';


@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {

  profile:any;

  constructor(private miServicio:ProfileService) { }

  ngOnInit(): void {
    this.miServicio.getProfile().subscribe(data => {
      console.log(data);
      this.profile=data;
    })

  }

}
