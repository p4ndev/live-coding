import './index.css';
import React                    from 'react';
import ReactDOM                 from 'react-dom';
import AutoCompleteForm         from './components/smart/AutoCompleteForm';

ReactDOM.render(
  <React.StrictMode>
    <AutoCompleteForm />
  </React.StrictMode>,
  document.getElementById('root')
);