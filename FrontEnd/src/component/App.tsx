import React, { Component }         from 'react';
import { AppProps, AppStates }      from '../entity';
import Header                       from './container/Header';
import { Outlet }                   from "react-router-dom";

export default class App extends Component<AppProps, AppStates> {

  state = {}

  render() {
    return (
      <React.Fragment>
        
        <Header />

        <div className="container pt-5">
          <Outlet />
        </div>

      </React.Fragment>
    );
  }

}
