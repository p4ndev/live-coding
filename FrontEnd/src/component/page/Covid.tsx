import React, { useEffect, useState }       from 'react'
import { MainHeader, Submit, Notification } from '../dumb';
import { IEmployee }                        from '../../entity/Employee';
import EmployeeService                      from '../../service/EmployeeService';
import StorageProvider                      from '../../provider/StorageProvider';

export const Covid = () => {

  const employeeDataSource : IEmployee[] = [];
  const emailsSelected = new Map();
  var innerTimer : any;
  
  const [employees,         setEmployees]       = useState(employeeDataSource);
  const [emails,            setEmails]          = useState(emailsSelected);
  const [emailCounter,      setEmailCounter]    = useState(0);

  const [notification,      setNotification]    = useState(false);
  const [serverError,       setServerError]     = useState(false);
  const [serverMessage,     setServerMessage]   = useState("");

  useEffect(() => {
    return () => {
      clearInterval(innerTimer)
    };
  }, [innerTimer]);

  useEffect(() => {
    EmployeeService.RetrieveAsync()
      .then(res => setEmployees(res.data as IEmployee[]));
  }, []);

  const handleSelection = (ent : IEmployee, obj : any) => {
    if(obj.target.checked){
      let newItems = emails.set(ent.id, ent.email);
      setEmails(newItems);
      setEmailCounter(emailCounter+1);
    }else{      
      if(emails.delete(ent.id)){        
        setEmails(emails);
        setEmailCounter(emailCounter-1);
      }
    }
  }

  const onSuccessOrFailure = (obj : any) => {

    let httpErrorCode = obj.status;
    if(!httpErrorCode) httpErrorCode = obj.response.status;

    switch(httpErrorCode){

      case 201:
        setServerMessage("everything is fine...");
        setServerError(false);
        break;

      case 400:
        setServerMessage("ome data was missing or in bad format.");
        setServerError(true);
        break;

      case 403:
        setServerMessage("operation doesn't allow you to do it.");
        setServerError(true);
        break;

      case 500:
        setServerMessage("server error, or any issue during the configuration.");
        setServerError(true);
        break;

      default:
        setServerMessage("undefined error.");
        setServerError(false);
        break;

    }

    setNotification(true);
    innerTimer = setTimeout(() => setNotification(false), 8000);

  }

  const handleSubmit = async () => {

    let preparedEmails : string[] = [];
    let currentEmail = StorageProvider.GetEmail();
    emails.forEach((value) => preparedEmails.push(value));

    console.log(preparedEmails);
    console.log(currentEmail);

    await EmployeeService.NotifyAsync(currentEmail, preparedEmails)
      .then(onSuccessOrFailure).catch(onSuccessOrFailure);

  }

  return (
    <main>

      <MainHeader prefix="Who do you want to " strong="notify" suffix="?" />

      <table className="mt-3 mb-3">
        <thead>
          <tr>
            <th style={{ width: "10%", textAlign: "center" }}>#</th>
            <th style={{ width: "90%" }}>Email</th>
          </tr>
        </thead>
        <tbody>
          {
            employees.map(
              e => (
                <tr key={e.id}>
                  <td className="text-center"><input type="checkbox" onChange={(o) => handleSelection(e, o)} /></td>
                  <td>{ e.email }</td>
                </tr>
              )
            )
          }
        </tbody>
      </table>

      { emailCounter > 0 && <Submit title="Send" onClick={handleSubmit} /> }
      
      { notification && <Notification prefix={serverError ? "Error:" : "Success:"} message={serverMessage} cssClass={serverError ? "error" : "success"} /> }

    </main>
  );

}