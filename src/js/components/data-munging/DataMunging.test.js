import React from "react";
import DataMunging from "./DataMunging.jsx";
import renderer from "react-test-renderer";

describe("<DataMunging /> functions", () => {
  let inst;
  beforeEach(() => {
    const wrapper = renderer.create(<DataMunging />);
    inst = wrapper.getInstance();
  });

  it("test suite must contain one test", () => {
    expect(true).toEqual(true);
  });
});
