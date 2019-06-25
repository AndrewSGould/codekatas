import React from "react";
import FizzBuzz from "./FizzBuzz.jsx";
import renderer from "react-test-renderer";

describe("<FizzBuzz /> functions", () => {
  let inst;
  beforeEach(() => {
    const wrapper = renderer.create(<FizzBuzz />);
    inst = wrapper.getInstance();
  });

  it("fizzbuzz function returns Fizz if it's a multiple of 3 (but not also 5)", () => {
    expect(inst.fizzbuzz(3)).toEqual("Fizz");
    expect(inst.fizzbuzz(6)).toEqual("Fizz");
    expect(inst.fizzbuzz(9)).toEqual("Fizz");
    expect(inst.fizzbuzz(12)).toEqual("Fizz");
    expect(inst.fizzbuzz(42)).toEqual("Fizz");
    expect(inst.fizzbuzz(63)).toEqual("Fizz");
    expect(inst.fizzbuzz(81)).toEqual("Fizz");
    expect(inst.fizzbuzz(87)).toEqual("Fizz");
    expect(inst.fizzbuzz(93)).toEqual("Fizz");
  });

  it("fizzbuzz function returns Buzz if it's a multiple of 3 (but not also 5)", () => {
    expect(inst.fizzbuzz(5)).toEqual("Buzz");
    expect(inst.fizzbuzz(10)).toEqual("Buzz");
    expect(inst.fizzbuzz(25)).toEqual("Buzz");
    expect(inst.fizzbuzz(65)).toEqual("Buzz");
    expect(inst.fizzbuzz(100)).toEqual("Buzz");
  });

  it("fizzbuzz function returns FizzBuzz if it's a multiple of 3 AND 5", () => {
    expect(inst.fizzbuzz(15)).toEqual("FizzBuzz");
    expect(inst.fizzbuzz(30)).toEqual("FizzBuzz");
    expect(inst.fizzbuzz(45)).toEqual("FizzBuzz");
    expect(inst.fizzbuzz(90)).toEqual("FizzBuzz");
  });
});
