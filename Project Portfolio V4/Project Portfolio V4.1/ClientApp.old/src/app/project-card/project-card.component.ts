import { Component, OnInit } from '@angular/core';
import { Project } from '../view-models/Project';

@Component({
  selector: 'app-project-card',
  templateUrl: './project-card.component.html',
  styleUrls: ['./project-card.component.css'],
  inputs: ['project']
})
export class ProjectCardComponent implements OnInit {

  constructor() {
    
  }

  ngOnInit() {
  }

}
