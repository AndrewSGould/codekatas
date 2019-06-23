import React from "react";
import KarateChop from "./KarateChop.jsx";
import renderer from "react-test-renderer";

describe("<KarateChop /> functions", () => {
  let inst;
  beforeEach(() => {
    const wrapper = renderer.create(<KarateChop />);
    inst = wrapper.getInstance();
  });

  it("chop function returns -1 when target is not found", () => {
    expect(inst.iterativeChop(3, [])).toEqual(-1);
    expect(inst.iterativeChop(3, [1])).toEqual(-1);

    expect(inst.iterativeChop(0, [1, 3, 5])).toEqual(-1);
    expect(inst.iterativeChop(2, [1, 3, 5])).toEqual(-1);
    expect(inst.iterativeChop(4, [1, 3, 5])).toEqual(-1);
    expect(inst.iterativeChop(6, [1, 3, 5])).toEqual(-1);

    expect(inst.iterativeChop(0, [1, 3, 5, 7])).toEqual(-1);
    expect(inst.iterativeChop(2, [1, 3, 5, 7])).toEqual(-1);
    expect(inst.iterativeChop(4, [1, 3, 5, 7])).toEqual(-1);
    expect(inst.iterativeChop(6, [1, 3, 5, 7])).toEqual(-1);
    expect(inst.iterativeChop(8, [1, 3, 5, 7])).toEqual(-1);
  });

  it("chop function returns appropriate index when target is found", () => {
    expect(inst.iterativeChop(1, [1])).toEqual(0);

    expect(inst.iterativeChop(1, [1, 3, 5])).toEqual(0);
    expect(inst.iterativeChop(3, [1, 3, 5])).toEqual(1);
    expect(inst.iterativeChop(5, [1, 3, 5])).toEqual(2);

    expect(inst.iterativeChop(1, [1, 3, 5, 7])).toEqual(0);
    expect(inst.iterativeChop(3, [1, 3, 5, 7])).toEqual(1);
    expect(inst.iterativeChop(5, [1, 3, 5, 7])).toEqual(2);
    expect(inst.iterativeChop(7, [1, 3, 5, 7])).toEqual(3);
  });
});
