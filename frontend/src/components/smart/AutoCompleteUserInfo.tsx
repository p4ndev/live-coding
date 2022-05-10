import { useEffect, useRef, useState }      from "react";
import { AutoCompleteUserInfoProps }        from "../../shared/entities/AutoCompleteUserInfoProps";

export default function AutoCompleteUserInfo(props : AutoCompleteUserInfoProps){

    const [innerTerm, setInnerTerm] = useState(props.term);
    const searchableField = useRef<HTMLHeadingElement>(null);

    useEffect(() => {
        setTimeout(() => {
            if(searchableField.current && props.model)
                searchableField.current.innerHTML = props.model.fullName.toUpperCase().replaceAll(innerTerm.toUpperCase(), "<span>"+innerTerm.toUpperCase()+"</span>");
        }, 40);
    }, []);
    
    return (
        <article>
            <strong className="u-uid">#{ props.model?.id }</strong>
            <h1 className="p-name" ref={searchableField}>{ props.model?.fullName }</h1>
            <em className="u-email">{ props.model?.email }</em>
        </article>
    );
}