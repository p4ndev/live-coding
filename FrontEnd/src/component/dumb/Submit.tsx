import React                from 'react';
import { ClickableProps }   from '../../entity';

export const Submit = (props : ClickableProps) => 
    <input type="button" value={ props.title } className="btn black d-sm-block d-md-block d-lg-block" onClick={props.onClick} />;
