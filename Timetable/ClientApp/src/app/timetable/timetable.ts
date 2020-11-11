
import { Classroom } from "./classroom";
import { Teacher } from "./teacher";
import { Group } from "./group";
import { Day } from "./day";
import { Time } from "./time";

export class Timetable {
    constructor(
        public id?: number,
        public subject?: string,
        public type?: string,
        public classroom?: Classroom,
        public classroomid?: number,
        public teacher?: Teacher,
        public teacherid?: number,
        public group?: Group,
        public groupid?: number,
        public day?: Day,
        public dayid?: number,
        public time?: Time,
        public timeid?: number,) { }
}