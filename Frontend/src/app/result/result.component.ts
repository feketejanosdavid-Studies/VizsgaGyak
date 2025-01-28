import { Component, Input } from '@angular/core';

@Component({
  selector: 'app-result',
  standalone: false,
  
  templateUrl: './result.component.html',
  styleUrl: './result.component.css'
})
export class ResultComponent {
  @Input() results: any
}
