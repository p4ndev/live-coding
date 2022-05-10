import React          from 'react';
import Menu           from './Menu';
import { Logotipo }   from '../dumb';

export default function Header() {
  return (
    <header role="menu" className="pb-4">
        <nav className="container mt-4">
          <ul className="row">
              <li className="col-12 col-sm-3 pt-2">
                  <Logotipo />
              </li>
              <Menu />
          </ul>
        </nav>
    </header>
  )
}
