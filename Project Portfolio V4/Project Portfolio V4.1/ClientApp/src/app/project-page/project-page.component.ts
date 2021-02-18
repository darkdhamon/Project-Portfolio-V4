import { Component, OnInit } from '@angular/core';
import { Project } from '../view-models/Project';
import { ApiResponse } from '../view-models/ApiResponse';

import { HttpClient } from "@angular/common/http";

@Component({
  selector: 'app-project-page',
  templateUrl: './project-page.component.html',
  styleUrls: ['./project-page.component.css']
})
export class ProjectPageComponent implements OnInit {

  proj: Project;

  constructor(private http: HttpClient) {
    this.proj = null;
  }

  ngOnInit(): void {
    ///Make call to DB for porject lists
    this.http.get<ApiResponse<Project>>("api/Project/page/1").subscribe(response => {
      this.proj = response.data;
      console.log("ProjectListComponent - response:", response);
    });
  }

}
