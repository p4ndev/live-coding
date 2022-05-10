import { AutoCompletePanelItemProps } from "../../shared/entities/AutoCompletePanelItemProps";

export default function AutoCompletePanelItem(props : AutoCompletePanelItemProps) {
    return <span>{ props.fullName }</span>;
}