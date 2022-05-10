import React, { useEffect, useState }                                 from 'react'
import { MainHeader, SubHeader, Submit, Switchable,Notification }     from '../dumb';
import ActivityService                                                from '../../service/ActivityService';
import StorageProvider                                                from '../../provider/StorageProvider';

export const Register = () => {

  var innerTimer : any;

  const [email,             setEmail]           = useState(StorageProvider.GetEmail());
  const [entranceAction,    setEntranceAction]  = useState(true);  
  const [notification,      setNotification]    = useState(false);
  const [serverError,       setServerError]     = useState(false);
  const [serverMessage,     setServerMessage]   = useState("");

  useEffect(() => StorageProvider.SetEmail(email ?? ""), [email]);

  useEffect(() => {
    return () => {
      clearInterval(innerTimer)
    };
  }, [innerTimer]);

  const handleEmail = (e : any) => setEmail(e.target.value);

  const handleEntranceOrExit = () => setEntranceAction(!entranceAction);

  const handleSubmit = async () => {
    await (
      entranceAction ? ActivityService.SaveEntranceAsync(email) : ActivityService.SaveExitAsync(email)
    ).then(onSuccessOrFailure).catch(onSuccessOrFailure);
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

      case 405:
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

  return (
    <main>

      <MainHeader prefix="Please, fill " strong="you email" suffix="." />

      <div className="row mb-4">
        <div className="col-12">  
          <input type="email" placeholder="E-mail *" style={{ width: "100%" }} value={email} onChange={handleEmail} />
        </div>
      </div>

      <SubHeader prefix="What are you " strong="up to" suffix="?" />

      <div className="row">
        <div className="col-6">
          <Switchable title="I'm arriving" cssClass={entranceAction ? "active" : ""} onClick={handleEntranceOrExit} />
        </div>
        <div className="col-6">
          <Switchable title="I'm leaving" cssClass={!entranceAction ? "active" : ""} onClick={handleEntranceOrExit} />
        </div>
      </div>

      {email.length > 3 && <Submit title="Send" onClick={handleSubmit} /> }

      { notification && <Notification prefix={serverError ? "Error:" : "Success:"} message={serverMessage} cssClass={serverError ? "error" : "success"} /> }

    </main>
  )

}