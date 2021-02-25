import {Component, Input, OnInit} from '@angular/core';
import {Project, ProjectCard} from '../view-models/Project';

@Component({
  selector: 'app-project-card',
  templateUrl: './project-card.component.html',
  styleUrls: ['./project-card.component.scss'],
})
export class ProjectCardComponent implements OnInit {

  @Input() project: ProjectCard
  constructor() {
    this.project = new ProjectCard();
  }

  ngOnInit() {
  }

}
