import React from "react";
import DataMunging from "./DataMunging.jsx";
import renderer from "react-test-renderer";
import dayTemps from "./dayTemps";

describe("<DataMunging /> functions", () => {
  let inst;
  let dayTempsList = [];

  beforeEach(() => {
    const wrapper = renderer.create(<DataMunging />);
    inst = wrapper.getInstance();
  });

  // TODO: Jest TestCases?
  it("getSmallestTempSpread", () => {
    dayTempsList = [];
    dayTempsList.push(new dayTemps(1, 88, 59));
    dayTempsList.push(new dayTemps(2, 79, 63));
    dayTempsList.push(new dayTemps(3, 77, 55));

    expect(inst.getSmallestTempSpread(dayTempsList)).toEqual(2);
  });
});
