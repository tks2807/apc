import { Group } from "./group";

export class Student {
    constructor(
        public id: number,
        public fname: string,
        public lname: string,
        public moodleid: string,
        public email: string,
        public group: Group,
        public groupid: number) { }
}