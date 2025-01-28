import { Component } from '@angular/core';
import { BaseService } from '../base.service';

@Component({
  selector: 'app-players',
  standalone: false,
  
  templateUrl: './players.component.html',
  styleUrl: './players.component.css'
})
export class PlayersComponent {
  players:any
  constructor(private base: BaseService) {
    this.base.getAll().subscribe(
      (res) => {
        this.players = res
        this.players.map((e:any) => e.visibleResult = false)
      }
      
    )
  }
}
