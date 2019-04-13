import React, { Component } from "react";
import ReactDOM from "react-dom";
import Nav from "../presentational/nav/Nav.jsx";
import FormContainer from "../container/FormContainer.jsx";

let introBlock = {
  display: "inline-block",
  width: "200px"
};

class AppContainer extends Component {
  constructor() {
    super();
  }

  render() {
    return (
      <div>
        <noscript>You must enable Javascript to run this website!</noscript>
        <Nav />
        <main>
          <section className="intro">
            <div style={introBlock}>
              <span>Andrew S Gould</span>
              <span>Developer, Designer</span>
            </div>
            <div style={introBlock}>
              <p>
                Hi, and welcome to my website! This is my small corner of the
                net where I host my independent projects and organize my
                thoughts. I'll document hurdles, musings, and strokes of
                inspiration as I journey through software development.
              </p>
            </div>
          </section>

          {/* TODO: Add skillsets and proficiency levels (advanced,proficient,etc) here */}
          {/* TODO: Insert experience timeline here */}
          {/* TODO: Add contact form */}
          <FormContainer />
        </main>
        <footer />
      </div>
    );
  }
}

export default AppContainer;

const wrapper = document.getElementById("main-body");
wrapper ? ReactDOM.render(<AppContainer />, wrapper) : false;
