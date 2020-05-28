import { Component, OnInit, ViewChild } from '@angular/core';
// import { OwlOptions } from 'ngx-owl-carousel-o';
import { GridService } from './services/grid.service';
import { BehaviorSubject } from 'rxjs';
@Component({
  selector: 'app-grid',
  templateUrl: './grid.component.html',
  styleUrls: ['./grid.component.css']
})
export class GridComponent implements OnInit {

  constructor(
    public gridService: GridService
  ) { }
  SlideOptions = { items: 1, dots: true, nav: true };
  CarouselOptions = { items: 3, dots: true, nav: true };  
  ricksList: any;

  ngOnInit() {
    this.gridService.get().subscribe(res => {
      console.log(res);
      this.ricksList =  new BehaviorSubject<any>(res);
      
    });
  }

}
