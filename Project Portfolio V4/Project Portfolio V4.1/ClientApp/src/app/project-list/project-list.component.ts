import { Component, OnInit } from '@angular/core';
import { Project } from '../view-models/Project';
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
    this.http.get<Project[]>("api/Project/page/1").subscribe(data => {
      ///For testing, I'm duplicating the data returned from core
      this.projects = data;//[...data, ...data, ...data];
      console.log("ProjectListComponent - data:", data);
    });
  }

}
