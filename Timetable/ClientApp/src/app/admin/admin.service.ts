import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Teacher } from '../timetable/teacher';


@Injectable()
export class AdminService {
    private url = "/api/teacher";

    constructor(private http: HttpClient) {
    }

    createTeacher(teacher: Teacher) {
        return this.http.post(this.url + '/createteacher', teacher);
    }

   
}