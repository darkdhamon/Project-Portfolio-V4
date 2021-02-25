import { Component, OnInit, Input } from '@angular/core';
import { Project } from '../view-models/Project';
import { ApiResponse } from '../view-models/ApiResponse';

import { HttpClient } from "@angular/common/http";
import { ActivatedRoute } from '@angular/router';
import * as moment from "moment";

@Component({
  selector: 'app-project-page',
  templateUrl: './project-page.component.html',
  styleUrls: ['./project-page.component.scss']
})
export class ProjectPageComponent implements OnInit {

  project: Project;

  constructor(private http: HttpClient, private route: ActivatedRoute) {
    this.project = new Project();
  }

  ngOnInit(): void {
    let id = this.route.snapshot.params['id'];
    ///Make call to DB for porject lists
    console.log("ProjectPageComponent - ngOnInitngOnInit");
    this.http.get<ApiResponse<Project>>("api/Project/" + id).subscribe(response => {
      this.project = response.data;
      console.log("ProjectPageComponent - response:", response);
    });
  }

  displayDates() {
    const start = moment(this.project.startDate).format("MMM YYYY");
    const end = moment(this.project.endDate).format("MMM YYYY");
    return `${start} - ${end}`
  }

}
