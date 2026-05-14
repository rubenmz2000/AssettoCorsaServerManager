import { localClient } from '../api/apiClient'
import type { Car } from '../types/Car'

export const getCars = async (): Promise<Car[]> => {
    const response = await localClient.get<Car[]>('/api/File/cars')
    return response.data
}