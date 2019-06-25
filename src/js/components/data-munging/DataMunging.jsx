import React, { Component } from "react";
import dayTemps from "./dayTemps.js";

Array.prototype.hasMin = function(attrib) {
  return this.reduce((prev, curr) =>
    prev[attrib] < curr[attrib] ? prev : curr
  );
};

// TODO: Why doesn't this work?
// Array.prototype.hasMin = attrib => {
//   return this.reduce((prev, curr) =>
//     prev[attrib] < curr[attrib] ? prev : curr
//   );
// };

class DataMunging extends Component {
  // SPEC
  /// write a program to output the day number (column one) with the
  /// smallest temperature spread (the maximum temperature is the second
  /// column, the minimum the third column).

  // fetch data here, component has rendered once (render spinner?)
  // this renders when the fetched data is stored to the local state
  // with setState()
  componentDidMount() {
    // bring in loader as a txt file
    // grab each line to parse through
    // first line is column headers. split by spaces and build structure
    // loop from 3rd line on, until you find 'mo': this is the summary
    /// Day (Dy) starts at idx2
    /// Maximum Temperature (MxT) starts at idx5
    /// Minimum Temperature (MnT) starts at idx11
    // for the mo line, treat it as a summary objects
  }

  getSmallestTempSpread = dayTempsList => {
    let results = [];

    for (var day of dayTempsList) {
      let diff = day.maxTemp - day.minTemp;
      results.push({ day: day.date, diff: diff });
    }

    return results.hasMin("diff").day;
  };

  render() {
    return <></>;
  }
}

export default DataMunging;
