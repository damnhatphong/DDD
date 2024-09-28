### The importance of data validation
Data validation are essential to every application, in fact, to every function you write that consume data.

### A Function Structure
a typical function structure would be like this:

step 1: validating the argument, data, input

step 2: perform the flows, the purpose of the function (main flow and its deviation - conditional cases [if, switch])

step 3: receive the output (check and validate the output), after performing the main function, you might also want to check the output too.

step 4: error handling, consider all the errors that would occur in your function,
- be intentional, Errors should be apply when the dependencies of the function fails, or when the validation fails with critical issue
- for other case, it is better to return the false value.
- if your are writing the function return boolean, this is straight forward
- for other primitive type, don't return the default value as it is confusing, throw error instead.
- For the return value, 

step 5: define the return value.

<b>Return null or not return null?</b>

- For string type or character type: return null if you need to know if the item exists or not. 
for example string, when you return empty, it does not mean the string is null, just empty value.
although it will create duplicated code when handling null value in the client site and is not recommended in clean code.
However, I think it worth to distinguish the two.
- For classes or object, if the entity is not found, if you return a default class and has a bunch of null property in it, how should the client handle the class?
- For Datetime, treat it as object or classes.
- For number, floating, decimal, boolean, treat them as string.
- For pointer, pointer will always existing, however you need to take responsibility to free the point memory to avoid memory leak. 
Pointer can also pointing to another pointer, remember the rule of 3, don't make the pointer exceed 3 layers. Note that pointer can point to null value as well.

<b>Throw exception or not throw exception?</b>

- An exception is thrown when a fundamental assumption of the current code block is found to be false.

### How to perform data validation in C#, .NET

First of all, there are two type of validation I can think of:

- <b><i>The superficial and peripheral validation.</i></b> 
this is the validation to check if all values are in the right form. 
This is probably the first thing you do. For example, you want to validate if a string is not empty or that a field falls in a range of predefined values.

- <b><i>Domain validation is about business rules.</i></b>
This kind of validation is performed in the application or domain layer of your app. 
A domain model is responsible to protect his own state. So the most of the validation goes in a domain model. 
If you need to validate state over multiple domain models, you would check this in the application layer. 
This is where your command handlers should be. 

### So How Many way to do it in C#, .NET?

#### My lovely classic way, Just write code to do it

Pros:
- simple, straight to the point, everyone can understand without learning any framework tools or library
- easy to customize as the way you like since it is just normal code.

cons:
- Error proning since it is not standardized and everyone can has their own way or writing the functions.
- Might be abit hard to maintain the code.


#### Fluent validation

Pros:
- Fluent syntax. (extension chain methods)
- Reusable rules.
- Asynchronous validations.
- Customizable and extensible.
- Decoupling. A dedicated validator class is created standing outside of the main class (business logic), so it would pollute the class.

cons
- 3rd library, so you need to be careful and manage the dependencies well.

#### Data annotations

Pros:
- Integrated into .NET, no extra packages needed.
- Fast learning curve.
- Reusable validations
- you can write custom validation attribute, check this https://learn.microsoft.com/en-us/aspnet/core/mvc/models/validation?view=aspnetcore-8.0

cons:
- The annotation is written directly on top of the property, so it pollute the code
- Out of the box attributes are very blunt and cheap, mostly you will need to create custom and dedicated validation object.