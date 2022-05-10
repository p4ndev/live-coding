import React              from 'react';
import ReactDOM           from 'react-dom/client';

import {
  BrowserRouter,
  Routes,
  Route,
} from "react-router-dom";

import App                from './component/App';
import { Report }         from './component/page/Report';
import { Register }       from './component/page/Register';
import { Covid }          from './component/page/Covid';
import { Welcome }        from './component/page/Welcome';

const root = ReactDOM.createRoot(
  document.getElementById('root') as HTMLElement
);

root.render(
    <BrowserRouter>
      <Routes>
        <Route path="/" element={<App />}>
          <Route path="/" element={<Welcome />} />
          <Route path="register" element={<Register />} />
          <Route path="report" element={<Report />} />
          <Route path="covid" element={<Covid />} />
        </Route>
      </Routes>
    </BrowserRouter>
);
