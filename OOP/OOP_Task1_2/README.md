# Task for OOP practics.

Write a public abstract Animal class that will describe Trarin.

It should include the following members:

1. Public auto-generated parameter (get; set;) Weight of type float.
2. Public auto-generated parameter (get; set;) Color of type string.
3. A public animal constructor that takes two arguments: a color type string, a weight type float, and assigns these arguments to auto-generated parameters.
4. A public abstract MakeSound method without arguments that returns a string.

Write a public abstract AnimalWithTail class that describes animals with a tail and imitates the Animal class. It should include the following members:

1. Public auto-generated parameter (get; set;) TailLength of type float.
2. An AnimalWithTail public constructor that accepts three arguments: color type string, weight type float, tailLength type float, and assigns these arguments to auto-generated parameters (you must call a base type constructor with two arguments).

Write a public Cat class that will describe the cat and inherit the AnimalWithTail class. It should include the following members:

1. A public Cat constructor that accepts three arguments: color type string, weight type float, tailLength type float, and assigns these arguments to auto-generated parameters (you must call a base type constructor with three arguments).
2. Private Purr method without arguments that returns a string "purrrrrrrr".
3. Private Meow method without arguments that returns a string "Meow".
4. The public override MakeSound method with no arguments that returns the result of a Purr () + Meow () call.
5. A public override ToString method without arguments that returns $ $ "This is a Cat, Color = {Color}, Weight = {Weight}, TailLength = {TailLength}".

Write a public Dog class describing the dog and imitating the AnimalWithTail class. It should include the following members:

1. A public Dog constructor that accepts three arguments: color type string, weight type float, tailLength type float, and assigns these arguments to auto-generated parameters (you must call a base type constructor with three arguments).
2. Public override MakeSound method without arguments, which returns “Woof”.
3. Public override argument-free ToString method that returns $ $ "This is a Dog, Color = {Color}, Weight = {Weight}, TailLength = {TailLength}".
