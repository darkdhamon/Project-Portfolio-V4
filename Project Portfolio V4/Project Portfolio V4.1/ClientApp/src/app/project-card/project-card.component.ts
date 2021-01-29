import { Component, OnInit } from '@angular/core';
import { Project } from '../view-models/Project'

@Component({
  selector: 'app-project-card',
  templateUrl: './project-card.component.html',
  styleUrls: ['./project-card.component.css']
})
export class ProjectCardComponent implements OnInit {

  project: Project

  constructor(project: Project) {
    this.project = project;
  }

  ngOnInit() {
  }

}
