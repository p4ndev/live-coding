import { EBehavior } from "../enums/EBehavior"

export type AutoCompleteFieldProps = {
    currentBehavior : EBehavior,
    onKeyUp         : (e : string | undefined) => void
}