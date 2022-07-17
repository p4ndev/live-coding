function Grid({ cars }) {
    return (
        <table>
            <thead>
                <tr>
                    <th>Id</th>
                    <th>Name</th>
                    <th>Price</th>
                    <th>Year</th>
                </tr>
            </thead>
            <tbody>
                {
                    cars.map(
                        (item) => (
                            <tr key={item.id}>
                                <td>{item.id}</td>
                                <td>{item.name}</td>
                                <td>{item.price}</td>
                                <td>{item.year}</td>
                            </tr>
                        )
                    )
                }
            </tbody>
        </table>
    );    
}

export default Grid;