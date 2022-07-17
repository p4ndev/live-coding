import "./index.css";
import React from 'react';
import { Honda } from "./data/Honda";
import ReactDOM from 'react-dom/client';
import Vehicles from "./product/Vehicles";

ReactDOM.createRoot(
  document.getElementById('root')
).render(
  <React.StrictMode>
    <Vehicles list={Honda} />
  </React.StrictMode>
);