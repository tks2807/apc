import { Component } from '@angular/core';

import * as XLSX from 'xlsx'; 
import { Teacher } from '../timetable/teacher';
import { AdminService } from '../admin/admin.service';

@Component({
  selector: 'admin-root',
  templateUrl: './admin.component.html'
})
export class AdminComponent {
  title = 'XlsRead';
  file:File
    arrayBuffer: any
    jsonobj: any
    filelist: Teacher[];
    arraylist: any
    array: string[];


    constructor(private dataService: AdminService) { }


  addfile(event) 
  {
  this.file= event.target.files[0]; 
  let fileReader = new FileReader();
  fileReader.readAsArrayBuffer(this.file); 
  fileReader.onload = (e) => {
      this.arrayBuffer = fileReader.result;
      var data = new Uint8Array(this.arrayBuffer);
      var arr = new Array();
      for(var i = 0; i != data.length; ++i) arr[i] = String.fromCharCode(data[i]);
      var bstr = arr.join("");
      var workbook = XLSX.read(bstr, {type:"binary"});
      var first_sheet_name = workbook.SheetNames[0];
      var worksheet = workbook.Sheets[first_sheet_name];
      console.log(XLSX.utils.sheet_to_json(worksheet,{raw:true}));
      this.arraylist = XLSX.utils.sheet_to_json(worksheet, { raw: true });
      console.log(this.arraylist);
      this.jsonobj = JSON.stringify(this.arraylist).toString();
      console.log(this.jsonobj);   
  }
}
}
