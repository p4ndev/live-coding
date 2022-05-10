import React                from 'react';
import { HeaderProps }      from '../../entity';

export const SubHeader = (props : HeaderProps) => 
    <h3>{ props.prefix }<span>{ props.strong }</span>{ props.suffix }</h3>;
