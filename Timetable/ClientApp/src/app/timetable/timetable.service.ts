import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';


@Injectable()
export class TimetableService {
    private urlles = "/api/timetable";
    private urlteach = "/api/teacher";
    private urlclass = "/api/classroom";
    private urlgrp = "/api/group";

    constructor(private http: HttpClient) {
    }

    getAll() {
        return this.http.get(this.urlles + '/getlessons');
    }

    getById(id: number) {
        return this.http.get(this.urlles + '/id/' + id);
    }

    getByStudent(id: number) {
        return this.http.get(this.urlles + '/student/' + id);
    }

    getByGroup(id: number) {
        return this.http.get(this.urlles + '/group/' + id);
    }

    getByTeacher(id: number) {
        return this.http.get(this.urlles + '/teacher/' + id);
    }

    getByClassroom(id: number) {
        return this.http.get(this.urlles + '/classroom/' + id);
    }

    getAllTeachers() {
        return this.http.get(this.urlteach + '/getteachers');
    }

    getAllClassrooms() {
        return this.http.get(this.urlclass + '/getclassrooms');
    }

    getAllGroups() {
        return this.http.get(this.urlgrp + '/getgroups');
    }

    
}