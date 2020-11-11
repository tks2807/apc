"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
exports.Timetable = void 0;
var Timetable = /** @class */ (function () {
    function Timetable(id, subject, type, classroom, classroomid, teacher, teacherid, group, groupid, day, dayid, time, timeid) {
        this.id = id;
        this.subject = subject;
        this.type = type;
        this.classroom = classroom;
        this.classroomid = classroomid;
        this.teacher = teacher;
        this.teacherid = teacherid;
        this.group = group;
        this.groupid = groupid;
        this.day = day;
        this.dayid = dayid;
        this.time = time;
        this.timeid = timeid;
    }
    return Timetable;
}());
exports.Timetable = Timetable;
//# sourceMappingURL=timetable.js.map