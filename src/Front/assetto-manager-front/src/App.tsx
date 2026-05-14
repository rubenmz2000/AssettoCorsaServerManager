import { useState } from 'react'
import reactLogo from './assets/react.svg'
import viteLogo from './assets/vite.svg'
import heroImg from './assets/hero.png'
import './App.css'
import CarSelector from './pages/CarSelector.tsx'

function App() {
  const [count, setCount] = useState(0)

  return (
    <>
      <CarSelector />
    </>
  )
}

export default App
