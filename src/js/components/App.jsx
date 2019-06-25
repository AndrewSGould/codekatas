import React, { Component } from "react";
import ReactDOM from "react-dom";

import KarateChop from "./karate-chop/KarateChop.jsx";
import FizzBuzz from "./fizzbuzz/FizzBuzz.jsx";
import DataMunging from "./data-munging/DataMunging.jsx";

class App extends Component {
  render() {
    return (
      <>
        <noscript>You need to enable Javascript to run this website!</noscript>
        <main>
          <DataMunging />
        </main>
        <footer />
      </>
    );
  }
}

export default App;

const wrapper = document.getElementById("main-body");
wrapper ? ReactDOM.render(<App />, wrapper) : false;
