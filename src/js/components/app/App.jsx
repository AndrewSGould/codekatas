import React, { Component } from "react";
import ReactDOM from "react-dom";

class AppContainer extends Component {
  render() {
    return (
      <div>
        <noscript>You need to enable Javascript to run this website!</noscript>
        <main>Test</main>
        <footer />
      </div>
    );
  }
}

export default AppContainer;

const wrapper = document.getElementById("main-body");
wrapper ? ReactDOM.render(<AppContainer />, wrapper) : false;
