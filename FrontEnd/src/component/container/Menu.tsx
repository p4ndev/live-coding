import React            from 'react';
import { NavLink }      from "react-router-dom";

export default function Menu() {
  return (
    <React.Fragment>
        <li className="col-12 col-sm-3">
            <NavLink to="/register" className="btn-arrow black d-sm-block d-md-block d-lg-block ">Register</NavLink>
        </li>
        <li className="col-12 col-sm-3">
            <NavLink to="/report" className="btn-arrow black d-sm-block d-md-block d-lg-block ">Report</NavLink>
        </li>
        <li className="col-12 col-sm-3">
            <NavLink to="/covid" className="btn-arrow black d-sm-block d-md-block d-lg-block ">I'm Positive</NavLink>
        </li>
    </React.Fragment>
  )
}