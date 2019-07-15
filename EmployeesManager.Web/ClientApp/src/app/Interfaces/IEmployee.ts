import { IDepartment, Department } from "./IDepartment";

export interface IEmployee {
  id: number;
  name: string;
  email: string;
  department: Department;
  departmentId: number;
}

export class Employee implements IEmployee {

  id: number;
  name: string;
  email: string;
  department: Department;
  departmentId: number;
}

