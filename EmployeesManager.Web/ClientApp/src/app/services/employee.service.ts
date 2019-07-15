import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { IEmployee } from '../Interfaces/IEmployee';
import { IDepartment } from '../Interfaces/IDepartment';

@Injectable({
  providedIn: 'root'
})
export class EmployeeService {
  private http: HttpClient;

  constructor(httpClient: HttpClient) {
    this.http = httpClient;
  }


  GetAllDepartment() {
    return this.http.get<any>('/api/Department');
  }

  GetAllEmployees() {
    return this.http.get<any>('/api/Employee');
  }


  AddEmployee(employee: IEmployee) {
    return this.http.post<any>('/api/Employee', employee);
  }


  DeleteEmployee(id: number) {
    return this.http.delete<any>('/api/Employee/' + id);
  }

}
