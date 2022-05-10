import { AutoCompletePanelProps }       from "../../shared/entities/AutoCompletePanelProps";
import AutoCompletePanelItem            from "../presentation/AutoCompletePanelItem";

export default function AutoCompletePanel(props : AutoCompletePanelProps) {
    return (
        <dl>
            {
                props.source?.map(x =>
                    (
                        <dd key={x.id} onClick={() => props.onItemClicked(x.id)}>
                            <AutoCompletePanelItem fullName={x.fullName} />
                        </dd>
                    )
                )
            }
        </dl>
    );
}