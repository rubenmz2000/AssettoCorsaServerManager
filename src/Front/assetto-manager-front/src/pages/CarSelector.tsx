import { getCars } from '../services/localApiService'
import { useEffect, useState } from 'react'
import type { Car } from '../types/Car'

function CarSelector(){
    const [cars, setCars] = useState<Car[]>([])
    useEffect(() => {
        getCars().then(data => setCars(data))
    })
    return <>
        <h1>Car Selector</h1>
        { cars.map(car => 
        <div key={car.folderPath}>
            <h2>{car.name}</h2>
            <p>{car.brand}</p>
            <p>{car.description }</p>
            <p>{car.tags.join(', ')}</p>
        </div>)}
    </>
}

export default CarSelector