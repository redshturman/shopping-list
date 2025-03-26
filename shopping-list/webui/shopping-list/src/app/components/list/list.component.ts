import { Component, OnInit } from '@angular/core';
import { MainListService } from '../../services/main-list.service';
import { lastValueFrom } from 'rxjs';

@Component({
  selector: 'app-list',
  standalone: false,
  templateUrl: './list.component.html',
  styleUrl: './list.component.css'
})
export class ListComponent implements OnInit {
  products: any[] = [];

  ngOnInit(): void {
    this.getMainList();
  }

  constructor(private listService: MainListService) { }

  async getMainList() {
    try {
      const res = await lastValueFrom(this.listService.getMainList());
      console.log('API Response:', res);
      this.products = res;
      console.log('Products:', this.products);
    }
    catch (error) {
      console.log(error);
    }
  }
}
