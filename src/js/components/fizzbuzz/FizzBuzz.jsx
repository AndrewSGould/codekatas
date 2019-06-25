import React, { Component } from "react";

class FizzBuzz extends Component {
  constructor(props) {
    super(props);
    this.state = {
      input: Array.apply(null, { length: 101 }).map(Number.call, Number)
    };
  }

  fizzbuzz = value => {
    return value % 3 == 0 && value % 5 == 0
      ? "FizzBuzz"
      : value % 3 == 0
      ? "Fizz"
      : value % 5 == 0
      ? "Buzz"
      : value;
  };

  render() {
    return this.state.input.map(item => (
      <ul>
        <li>{this.fizzbuzz(item)}</li>
      </ul>
    ));
  }
}

export default FizzBuzz;
