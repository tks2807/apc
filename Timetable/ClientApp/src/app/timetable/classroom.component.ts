import { Component, OnInit } from '@angular/core';
import { Timetable } from './timetable';
import { TimetableService } from './timetable.service';
import { ActivatedRoute } from '@angular/router';
import { Teacher } from './teacher';
import { Group } from './group';
import { Classroom } from './classroom';


@Component({
    selector: 'app-class',
    templateUrl: './class.component.html',
    providers: [TimetableService]
})
export class ClassroomComponent implements OnInit {

    schedule: Timetable = new Timetable();
    schedules: Timetable[];
    teachers: Teacher[];
    groups: Group[];
    classrooms: Classroom[];
    id: number;


    constructor(private timetableservice: TimetableService, activeRoute: ActivatedRoute) {
        this.id = Number.parseInt(activeRoute.snapshot.params["id"]);
    }

    ngOnInit() {
        this.getAllClassrooms();
        this.getAllGroups();
        this.getAllTeachers();
        if (this.id) {
            this.getByClassroom(this.id);
        }
    }

    getByClassroom(id: number) {
        this.timetableservice.getByClassroom(this.id)
            .subscribe((data: Timetable[]) => this.schedules = data);
    }

    getAllTeachers() {
        this.timetableservice.getAllTeachers()
            .subscribe((data: Teacher[]) => this.teachers = data);
    }
    getAllGroups() {
        this.timetableservice.getAllGroups()
            .subscribe((data: Group[]) => this.groups = data);
    }
    getAllClassrooms() {
        this.timetableservice.getAllClassrooms()
            .subscribe((data: Classroom[]) => this.classrooms = data);
    }
}