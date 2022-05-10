import React                    from 'react';
import { InformationProps }     from '../../entity';

export const Notification = (props : InformationProps) => 
    <div className={"notification-bar " + props.cssClass}>
        <div className="container">
            <strong>{ props.prefix }</strong> { props.message }
        </div>
    </div>;
