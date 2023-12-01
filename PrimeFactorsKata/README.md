# PrimeFactors

Write a function that generates prime factors of a given natural number.
A prime number is only evenly divisible by itself and 1.

Note that 1 is not a prime number.

### Things to know
If the integer has no prime factors, return an empty list.

The data types of the argument and return value depend on the programming
language you are using.

### Example of method signature
Test.assertSimilar( primeFactors(60), [2, 2, 3, 5] );
Test.assertSimilar( primeFactors(6), [2, 3] );

### Input
One argument – a positive, non-zero integer

### Output
A list of the integer’s prime factors in numerical sequence

### Example
What are the prime factors of 60?

Our first divisor is 2. 2 goes into 60, leaving 30.
2 goes into 30, leaving 15.
2 doesn't go cleanly into 15. So let's move on to our next divisor, 3.
3 goes cleanly into 15, leaving 5.
3 does not go cleanly into 5. The next possible factor is 4.
4 does not go cleanly into 5. The next possible factor is 5.
5 does go cleanly into 5.
We're left only with 1, so now, we're done.
Our successful divisors in that computation represent the list of prime factors of 60: 2, 2, 3, and 5.

Check it out 👇🏽:

2 * 2 * 3 * 5
= 4 * 15
= 60

### Other examples
f(1)  ==>  []

f(4) -> [2, 2]

f(6) -> [2, 3]

f(8) -> [2, 2, 2]

f(9) -> [3, 3]

f(12) ==>  [2, 2, 3]

f(27) -> [3, 3, 3]