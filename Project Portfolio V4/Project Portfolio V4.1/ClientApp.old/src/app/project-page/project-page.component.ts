import { Component, OnInit, Input } from '@angular/core';
import { Project } from '../view-models/Project';
import { ApiResponse } from '../view-models/ApiResponse';

import { HttpClient } from "@angular/common/http";
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-project-page',
  templateUrl: './project-page.component.html',
  styleUrls: ['./project-page.component.css']
})
export class ProjectPageComponent implements OnInit {

  proj: Project;

  constructor(private http: HttpClient, private route: ActivatedRoute) {
    this.proj = {};
  }

  ngOnInit(): void {
    let id = this.route.snapshot.params['id'];
    ///Make call to DB for porject lists
    console.log("ProjectPageComponent - ngOnInitngOnInit");
    this.http.get<ApiResponse<Project>>("api/Project/" + id).subscribe(response => {
      this.proj = response.data;
      console.log("ProjectPageComponent - response:", response);
    });
  }

}
