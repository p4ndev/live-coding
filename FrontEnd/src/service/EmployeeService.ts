import HttpClient from "../provider/HttpClient";

const EmployeeService = {

    RetrieveAsync : () => HttpClient.get(
        "/employee"
    ),

    NotifyAsync : (emailFrom : string, emailTo : string[]) => HttpClient.put(
        "/covid", { employeeEmail: emailFrom, emails: emailTo }
    )

}

export default EmployeeService;