import React, { Component } from "react";

class FizzBuzz extends Component {
  constructor(props) {
    super(props);
    this.state = {
      input: Array.apply(null, { length: 101 }).map(Number.call, Number)
    };

    this.fizzles = this.state.input.map((item, key) => (
      <li key={key}>{this.fizzbuzz(item)}</li>
    ));
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
    return <ul>{this.fizzles}</ul>;
  }
}

export default FizzBuzz;
