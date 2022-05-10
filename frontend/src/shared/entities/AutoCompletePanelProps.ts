import IContact from "./IContact";

export type AutoCompletePanelProps = {
    source          : IContact[] | undefined,
    onItemClicked   : (id : number) => void
}