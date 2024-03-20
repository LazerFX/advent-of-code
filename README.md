# advent-of-code

For the Advent of Code explorations - may contain spoilers, nuts or random bad code.

## Problem Case

There are two parts to this solution.  I want to be able to write Advent of Code code without having the inherent added complexity of
having to parse and write extraneous test cases.  In this instance, I'd like to be able to simply say, "For day 1, the textual input
is something along these lines, and this is the output" and throw in an array copy-and-pasted from the Advent of Code webpage.  Then,
I can say, "For day 2, here are the inputs and expected outputs", and get them, and then do a "Here's the *real* input" and then I
can gather that into the output.

### The parts needed to make this work

I'm looking to build an xUnit Automator.  xUnit has several extension points to allow it to build and generate test cases, and I want
to plug an array of text objects into a full test case solution.  So:

1. This should have a test case that plugs into xUnit to check that the test cases are being generated as expected
1. This should generate test cases from string arrays
1. This should automate the generation of the text output
1. This should be clean and obvious in use, and performant
1. This should be extensible and usable for multiple years worth of output
