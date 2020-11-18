﻿import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { Routes, RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { TimetableComponent } from './timetable/timetable.component';
import { TeacherComponent } from './timetable/teacher.component';
import { ClassroomComponent } from './timetable/classroom.component';


const appRoutes: Routes = [
    { path: 'group/:id', component: TimetableComponent },
    { path: 'teacher/:id', component: TeacherComponent },
    { path: 'classroom/:id', component: ClassroomComponent },
    { path: '**', redirectTo: '/' }
];

@NgModule({
    imports: [BrowserModule, FormsModule, HttpClientModule, RouterModule.forRoot(appRoutes)],
    declarations: [AppComponent, TimetableComponent, TeacherComponent, ClassroomComponent],
    providers: [],
    bootstrap: [AppComponent]

})
export class AppModule { }