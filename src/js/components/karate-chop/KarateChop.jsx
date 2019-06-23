import React, { Component } from "react";

class KarateChop extends Component {
  // GOALS
  /// keep notes of errors encountered. does frequency decrease?
  /// compare and contrast the various approaches. which one was more fun?
  /// which one goes into production? why?
  /// how did you come up with 5 different solutions?

  // SPEC
  /// write a binary chop method that takes an integer search target and a
  /// sorted array of integers. it should return
  /// the integer index of the target array, or -1 if the target is not in
  /// the array
  /// Assume less than 100k elements, performance isn't an issue

  iterativeChop = (target, sorted_array) => {
    let start = 0,
      stop = sorted_array.length - 1,
      mid = Math.floor(start + stop / 2);

    while (sorted_array[mid] !== target && start < stop) {
      if (target < sorted_array[mid]) stop = mid - 1;
      else start = mid + 1;

      mid = Math.floor((start + stop) / 2);
    }

    return sorted_array[mid] !== target ? -1 : mid;
  };

  render() {
    return <></>;
  }

  // NOTES
  /// original approach of actually modifying the array was flawed
  /// once you modify the array, you're losing track of the index position
}

export default KarateChop;
