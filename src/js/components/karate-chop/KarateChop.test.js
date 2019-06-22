import React from "react";
import KarateChop from "./KarateChop.jsx";
import renderer from "react-test-renderer";

describe("<KarateChop /> functions", () => {
  let inst;
  beforeEach(() => {
    const wrapper = renderer.create(<KarateChop />);
    inst = wrapper.getInstance();
  });

  it("test the control test", () => {
    expect(inst.sum(1, 2)).toBe(3);
  });

  it("chop function returns -1 when target is not found", () => {
    expect(inst.chop(3, [])).toEqual(-1);
    expect(inst.chop(3, [1])).toEqual(-1);

    expect(inst.chop(0, [1, 3, 5])).toEqual(-1);
    expect(inst.chop(2, [1, 3, 5])).toEqual(-1);
    expect(inst.chop(4, [1, 3, 5])).toEqual(-1);
    expect(inst.chop(6, [1, 3, 5])).toEqual(-1);

    expect(inst.chop(0, [1, 3, 5, 7])).toEqual(-1);
    expect(inst.chop(2, [1, 3, 5, 7])).toEqual(-1);
    expect(inst.chop(4, [1, 3, 5, 7])).toEqual(-1);
    expect(inst.chop(6, [1, 3, 5, 7])).toEqual(-1);
    expect(inst.chop(8, [1, 3, 5, 7])).toEqual(-1);
  });

  it("chop function returns appropriate index when target is found", () => {
    expect(inst.chop(1, [1])).toEqual(0);

    expect(inst.chop(1, [1, 3, 5])).toEqual(0);
    expect(inst.chop(3, [1, 3, 5])).toEqual(1);
    expect(inst.chop(5, [1, 3, 5])).toEqual(2);

    expect(inst.chop(1, [1, 3, 5, 7])).toEqual(0);
    expect(inst.chop(3, [1, 3, 5, 7])).toEqual(1);
    expect(inst.chop(5, [1, 3, 5, 7])).toEqual(2);
    expect(inst.chop(7, [1, 3, 5, 7])).toEqual(3);
  });
});
