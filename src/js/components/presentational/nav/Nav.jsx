import React from "react";
import "./Nav.styl";

class Nav extends React.Component {
  render() {
    return (
      <header>
        <nav>
          <ul>
            <li>Skills</li>
            <li>Experience</li>
            <li>Portfolio</li>
            <li>Blog</li>
            <li>Contact</li>
          </ul>
        </nav>
      </header>
    );
  }
}

export default Nav;
