import { Component, OnInit } from '@angular/core';
import { IEmployee, Employee } from '../../Interfaces/IEmployee';
import { EmployeeService } from '../../services/employee.service';
import { IDepartment, Department } from '../../Interfaces/IDepartment';
import { Router } from '@angular/router';

@Component({
  selector: 'app-create-employees',
  templateUrl: './create-employees.component.html',
  styleUrls: ['./create-employees.component.css']
})
export class CreateEmployeesComponent implements OnInit {
  private _employeeService: EmployeeService;
  public user: Employee; 
  public departments: Department[];


  constructor(employeeService: EmployeeService, private router: Router) {
    this._employeeService = employeeService;
    this.user = new Employee;
  }

  ngOnInit() {
    this._employeeService.GetAllDepartment().subscribe(result => {
      this.departments = result;
    });
  }

  salvar(user: Employee) {
    this._employeeService.AddEmployee(user).subscribe(result => {
      this.router.navigate(['/Listar']);
    });
  }


}
