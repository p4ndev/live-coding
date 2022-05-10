import { IEmployee } from "./Employee"

export interface IEmployeeActivity extends IEmployee{
    period : Date
    action : string
}