import { Observable } from 'rxjs';
import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Student } from 'src/app/interface/models';
import { environment } from 'src/environments/environment.development';


@Injectable({
  providedIn: 'root'
})
export class StudentServiceService {
  myUrl : string = environment.endpoint;
  myApi : string = '/api/StudentControllers';

  constructor(public http: HttpClient) { }

  getAllStudent(): Observable<Array<Student>> {
    return this.http.get<Array<Student>>(`${this.myUrl}${this.myApi}`);
  }
}
