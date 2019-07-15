import { Component, OnInit, ViewChild } from '@angular/core';
import { EmployeeService } from '../../services/employee.service';
import { IEmployee, Employee } from '../../Interfaces/IEmployee';
declare var $;
@Component({
  selector: 'app-list-employees',
  templateUrl: './list-employees.component.html',
  styleUrls: ['./list-employees.component.css']
})
export class ListEmployeesComponent implements OnInit {
  @ViewChild('dataTable', { static: false }) table;
  dataTable: any;
  private _employeeService: EmployeeService;
  private employees: Employee[];

  constructor(employeeService: EmployeeService) {
    this._employeeService = employeeService;
  }


  private montarTabela = function () {

    this.dtOptions = {

      "pagingType": "full_numbers",

      "lengthMenu": [[10, 25, 50, -1], [10, 25, 50, "Todos"]],

      responsive: true,

      language: {

        lengthMenu: "Exibir _MENU_ por paginas",

        zeroRecords: "Vazio",

        info: "Mostrando _PAGE_ de _PAGES_ paginas",

        infoEmpty: "Nenhum item para exibir",

        infoFiltered: "(filtered from _MAX_ total records)",

        search: "Buscar",

        oPaginate: {

          sNext: "Pr&oacuteximo",

          sPrevious: "Anterior",

          sFirst: "Primeiro",

          sLast: "&Uacuteltimo"

        }

      }



    };
    this.dataTable = $(this.table.nativeElement);

    this.dataTable.DataTable(this.dtOptions);
  }


  private listarEmployees() {

   
  }

  ngOnInit(): void {
    var self = this;
    this._employeeService.GetAllEmployees().subscribe(result => {
      this.employees = result;
      console.log(result);
      setTimeout(function () {
        self.montarTabela();
      }, 10);
    });
  }


  deleteEmployee(id: number) {
    this._employeeService.DeleteEmployee(id).subscribe(result => {
      this._employeeService.GetAllEmployees().subscribe(result => {
        this.employees = result;
      });
    });
  }

}
