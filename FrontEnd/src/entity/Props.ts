
export type AppProps = {}

export type ClickableProps = { title : string, linkTo? : string, cssClass? : string, onClick? : () => void };

export type HeaderProps = { prefix : string, strong : string, suffix? : string };

export type InformationProps = { prefix : string, message : string, cssClass? : string };