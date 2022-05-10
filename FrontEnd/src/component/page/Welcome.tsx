import React from 'react'
import welcome from "../../asset/welcome.jpg";

export const Welcome = () => {
  return (
      <div className="welcomePanel">
          <img src={welcome} alt="Welcome" />
      </div>
  );
}