import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-fetch-data',
  templateUrl: './fetch-data.component.html'
})
export class FetchDataComponent {
  public commits: GitHubCommit[];

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<GitHubCommit[]>(baseUrl + 'github').subscribe(result => {
      this.commits = result;
    }, error => console.error(error));
  }
}
interface GitHubCommit {
  by: string;
  date: string;
  url: string
}
