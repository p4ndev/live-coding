import React, { useRef }            from "react";
import { AutoCompleteUtil }         from "../../shared/services/AutoCompleteUtil";
import { AutoCompleteFieldProps }   from "../../shared/entities/AutoCompleteFieldProps";

export default function AutoCompleteField(props : AutoCompleteFieldProps) {

    const searchInput = useRef<HTMLInputElement>(null);

    const onInnerKeyUpHandler = (e : React.KeyboardEvent<HTMLInputElement>) => props.onKeyUp(searchInput.current?.value);

    return (
        <div>
            <input type="text" placeholder="Type at least 3 letters..." onKeyUp={onInnerKeyUpHandler} ref={searchInput} />
            { AutoCompleteUtil.shouldResetShow(props.currentBehavior) && <input type="reset" value="X" /> }
            { AutoCompleteUtil.shouldSpinnerShow(props.currentBehavior) && <button /> }
        </div>
    );

}