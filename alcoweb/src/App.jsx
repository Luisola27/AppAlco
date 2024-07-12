import { useState } from "react";
import NavBar from "./components/NavBar";
import { NAVIGATION_EVENT } from "./constants/navigate";
import './index.css' 
import { useEffect } from "react";
import GuaroForm from "./pages/GuaroForm";
// import AddAlco from "./pages/AddAlco";


function App() {

  // function navigate (href) {
  //   window.history.pushState({}, '', href)
  //   const navigationEvent = new Event(NAVIGATION_EVENT)
  //   window.dispatchEvent(navigationEvent)
  // }

  const [currentPath, setCurrentPath] = useState(window.location.pathname)

  useEffect(() => {
    const onLocationChange = () => {
      setCurrentPath(window.location.pathname)
    }

    window.addEventListener(NAVIGATION_EVENT, onLocationChange)

    return () => {
      window.removeEventListener(NAVIGATION_EVENT, onLocationChange)
    }
  }, [])

  console.log(currentPath);

  return (
    <>
      <NavBar />
      <GuaroForm />
    </>
  );
}

export default App;
