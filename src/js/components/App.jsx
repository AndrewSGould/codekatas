import React, { Component } from "react";
import ReactDOM from "react-dom";

import KarateChop from "./karate-chop/KarateChop.jsx";

class App extends Component {
  render() {
    return (
      <>
        <noscript>You need to enable Javascript to run this website!</noscript>
        <main>
          <KarateChop />
        </main>
        <footer />
      </>
    );
  }
}

export default App;

const wrapper = document.getElementById("main-body");
wrapper ? ReactDOM.render(<App />, wrapper) : false;
