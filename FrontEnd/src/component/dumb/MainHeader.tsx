import React                from 'react';
import { HeaderProps }      from '../../entity';

export const MainHeader = (props : HeaderProps) => 
    <h2>{ props.prefix }<span>{ props.strong }</span>{ props.suffix }</h2>;
