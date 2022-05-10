import React, { useEffect, useRef, useState }     from "react";
import { EBehavior }                              from "../../shared/enums/EBehavior";
import AutoCompletePanel                          from "../container/AutoCompletePanel";
import IContact                                   from "../../shared/entities/IContact";
import AutoCompleteField                          from "../presentation/AutoCompleteField";
import AutoCompleteUserInfo                       from "./AutoCompleteUserInfo";
import { AutoCompleteUtil }                       from "../../shared/services/AutoCompleteUtil";

export default function AutoCompleteForm() {
  
  const [model, setModel]             = useState<string>("");
  const [contact, setContact]         = useState<IContact>();
  const [contacts, setContacts]       = useState<IContact[]>([]);
  const [behavior, setBehavior]       = useState(EBehavior.None);
  const mainForm                      = useRef<HTMLFormElement>(null);
  const endpoint : string = "https://localhost:7232/api/contacts/find?fullname=";
  const solveCssClassNames            = AutoCompleteUtil.applyCssProperly(behavior);

  const singleItemClicked = (id : number) => {
    setContact(contacts.find(x => x.id === id));
    setTimeout(() => mainForm.current?.reset(), 80);
  }

  const resetHandler = (e : React.FormEvent<HTMLFormElement>) => {
    setModel("");
    setContacts([]);
    setBehavior(EBehavior.None);
  }

  const onKeyUpHandler = (e : string | undefined) => {
    if(!e) return;
    setModel(e);
    setBehavior(
      (model.length >= 0 && model.length < 3) ? 
      EBehavior.Invalid : EBehavior.Loading
    );
  }

  useEffect(() => {
    if(behavior === EBehavior.Loading){
      fetch(endpoint + model)
        .then(res => res.json())
        .then(apiResponse => {
          setTimeout(() => {
            if(apiResponse.length > 0){
              setBehavior(EBehavior.HasData);
              setContacts(apiResponse);
            }else{
              setBehavior(EBehavior.Empty);
              setModel("");
              setContacts([]);
            }
          }, 400);
        }).catch(() => {
          setBehavior(EBehavior.None);
          setModel("");
          setContacts([]);
        });
    }
  }, [behavior]);

  return (
    <form className={solveCssClassNames} onReset={resetHandler} ref={mainForm}>
      <AutoCompleteField onKeyUp={onKeyUpHandler} currentBehavior={behavior} />
      <AutoCompletePanel source={contacts} onItemClicked={singleItemClicked} />
      { contact && <AutoCompleteUserInfo model={contact} term={model} /> }
    </form>
  );

}


