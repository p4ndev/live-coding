import { EBehavior } from "../enums/EBehavior";

export const AutoCompleteUtil = {

    applyCssProperly: (whichBehavior : EBehavior) : string => {

        let cssClassNames = "";

        switch(whichBehavior){
            case EBehavior.Loading: cssClassNames = "loading";  break;
            case EBehavior.HasData: cssClassNames = "has-data"; break;
            case EBehavior.Empty:   cssClassNames = "empty";    break;
            case EBehavior.Invalid: cssClassNames = "invalid";  break;
        }

        return cssClassNames;
    },

    shouldResetShow: (behavior : EBehavior) : boolean => {
        return (behavior === EBehavior.HasData || behavior === EBehavior.Invalid || behavior === EBehavior.Empty);
    },

    shouldSpinnerShow: (behavior : EBehavior) : boolean => {
        return (behavior === EBehavior.Loading);
    }

};