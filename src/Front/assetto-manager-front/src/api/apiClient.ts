import axios from 'axios'

export const localClient = axios.create({ baseURL: 'http://localhost:5013'});