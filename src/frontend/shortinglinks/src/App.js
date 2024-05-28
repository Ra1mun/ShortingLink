import { BrowserRouter as Router, Routes, Route } from "react-router-dom";
import HomeContainer from "./containers/Home";
import RedirectHandlerContainer from "./containers/RedirectHandler";


function App() {
  return (

      <Router>
        <Routes>
          <Route path = '/' element = { <HomeContainer/> }/>
          <Route path = '/:shortAddres' element = { <RedirectHandlerContainer/> }/>
        </Routes>
      </Router>

  );
}

export default App;
