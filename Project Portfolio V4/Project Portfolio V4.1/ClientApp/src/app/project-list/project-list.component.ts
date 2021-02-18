import { Component, OnInit } from '@angular/core';
import { Project } from '../view-models/Project';
import { PagedApiResponse } from '../view-models/PagedApiResponse';

import { HttpClient } from "@angular/common/http";

@Component({
  selector: 'app-project-list',
  templateUrl: './project-list.component.html',
  styleUrls: ['./project-list.component.css']
})
export class ProjectListComponent implements OnInit {

  projects: Project[];
  page: number;
  totalPages: number;

  constructor(private http: HttpClient) {
    this.projects = [];
    this.page = 1;
    this.totalPages = 1;
  }

  generatePageArray(): number[] {
    let result: number[] = [];
    for (let _i = 0; _i < this.totalPages; _i++) {
      result.push(_i + 1);
    }
    return result;
  }

  ngOnInit(): void {
    ///Make call to DB for porject lists
    this.http.get<PagedApiResponse<Project[]>>("api/Project/page/" + this.page).subscribe(response => {
      this.projects = response.data;
      this.page = response.page;
      this.totalPages = response.totalPages;
      console.log("ProjectListComponent - response:", response);
    });
  }

}
