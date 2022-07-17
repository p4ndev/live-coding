import React, { useEffect, useState } from "react";
import Grid from "../dumb/Grid";

function Vehicles({ list }) {

  const [source, setSource] = useState([]);
  const [filter, setFilter] = useState("id");

  const isActive = (slug) => (slug === filter ? "active" : "");

  useEffect(() => {
    
    let tmp;

    switch(filter){
      
      case "price":
        tmp = [...list].sort(
          (l, r) => ((l.price > r.price) ? -1 : 1)
        );
        break;

      case "year":
        tmp = [...list].sort(
          (l, r) => {
            let l_d = new Date(l.year);
            let r_d = new Date(r.year);
            return ((l_d > r_d) ? -1 : 1);
          }
        );
        break;

      case "id":
      default:
        tmp = [...list];
        break;
      
    }

    setSource(tmp);

  }, [filter]);

  return (
    <>
      <nav>
        <button onClick={() => setFilter("id")}     className={isActive("id")}>Id</button>
        <button onClick={() => setFilter("price")}  className={isActive("price")}>Price</button>
        <button onClick={() => setFilter("year")}   className={isActive("year")}>Year</button>
      </nav>
      <Grid cars={source} />
    </>
  );

}

export default Vehicles;