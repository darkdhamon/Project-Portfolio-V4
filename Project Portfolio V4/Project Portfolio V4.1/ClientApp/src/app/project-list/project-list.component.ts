import { Component, OnInit } from '@angular/core';
import { Project } from '../view-models/Project';
import { ProjectListApiResponse } from '../view-models/ProjectListApiResponse';

import { HttpClient, HttpClientModule } from "@angular/common/http";

@Component({
  selector: 'app-project-list',
  templateUrl: './project-list.component.html',
  styleUrls: ['./project-list.component.css']
})
export class ProjectListComponent implements OnInit {

  projects: Project[];

  constructor(private http: HttpClient) {
 
    this.projects = [];
  }

  ngOnInit(): void {
    ///Make call to DB for porject lists
    this.http.get<ProjectListApiResponse>("api/Project/page/1").subscribe(response => {
      this.projects = response.data;
      console.log("ProjectListComponent - response:", response);
    });
  }

}
