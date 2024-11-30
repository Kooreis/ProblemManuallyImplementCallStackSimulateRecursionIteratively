# Question: How do you manually implement a call stack to simulate recursion iteratively? JavaScript Summary

The JavaScript code provided is a manual implementation of a call stack to simulate recursion iteratively. The code first defines a Stack class with methods for push, pop, peek, and isEmpty. The push method adds an element to the stack, the pop method removes the top element from the stack, the peek method returns the top element without removing it, and the isEmpty method checks if the stack is empty. The factorial function uses an instance of this Stack class to calculate the factorial of a number iteratively, which is typically done recursively. The function first pushes all numbers from the input number down to 1 onto the stack. Then, it initializes a result variable to 1 and enters a loop where it multiplies the result by each number popped from the stack until the stack is empty. This effectively calculates the factorial of the input number, as the factorial is the product of all positive integers up to that number. The result is then returned. The console.log statement at the end calls the factorial function with an argument of 5 and logs the result, which is 120.

---

# TypeScript Differences

The TypeScript version of the solution uses similar logic to the JavaScript version, but it leverages TypeScript's static typing and class-based object-oriented programming features to provide a more structured and type-safe solution.

Here are the key differences:

1. TypeScript uses classes and generics: In the TypeScript version, `Stack` and `Factorial` are implemented as classes, which is a more modern and structured approach compared to the prototype-based approach used in the JavaScript version. The `Stack` class in TypeScript also uses generics (`<T>`), which makes it a reusable data structure for any type of data, not just numbers.

2. TypeScript uses type annotations: TypeScript's static typing is used throughout the solution. For example, the `Stack` class methods `push`, `pop`, and `isEmpty` all have type annotations for their parameters and return values. This provides compile-time type checking, which can help catch potential bugs before runtime.

3. Different approach to calculate factorial: The TypeScript version uses a slightly different approach to calculate the factorial. It pushes the initial number onto the stack, then in each iteration of the loop, it multiplies the result by the top number on the stack, then pushes the next lower number onto the stack. This approach is more efficient as it avoids pushing all numbers onto the stack at once.

4. Error handling: The JavaScript version returns 'Underflow' when trying to pop an element from an empty stack. The TypeScript version does not include this error handling, instead it returns `undefined` when trying to pop an element from an empty stack, which is the default behavior of the `Array.pop()` method in JavaScript.

5. Encapsulation: The TypeScript version encapsulates the stack inside the `Factorial` class, which makes the code more modular and easier to maintain. The JavaScript version does not encapsulate the stack, which could potentially lead to issues if the stack is accessed or modified directly from outside the `factorial` function.

---

# C++ Differences

The C++ version of the solution also uses a stack to simulate recursion iteratively, similar to the JavaScript version. However, there are some differences in the language features and methods used in the two versions.

1. Stack Implementation: In JavaScript, a stack is implemented using an array and custom methods are defined for push, pop, peek, and isEmpty operations. In C++, the STL (Standard Template Library) provides a built-in stack data structure which has built-in methods for push, pop, and top (equivalent to JavaScript's peek) operations. The isEmpty operation in C++ is done using the empty() method.

2. Function Definitions: In JavaScript, functions are defined using the function keyword, while in C++, functions are defined using the return type, function name, and parameters in parentheses.

3. Looping: Both versions use while loops to push elements onto the stack and to pop elements from the stack. However, the C++ version has an additional check to break the outer loop when the stack is empty.

4. Printing: The JavaScript version calculates and returns the factorial of a number, while the C++ version prints the elements of the stack after each pop operation. The printStack function in C++ uses a copy of the stack to print and pop the elements.

5. Main Function: In C++, the main function is the entry point of the program, and it calls the simulateRecursion function. In JavaScript, the factorial function is called directly.

6. Variable Declaration: In JavaScript, variables are declared using let or const keywords. In C++, variables are declared with their data type, such as int for integers.

7. Namespace: The C++ version uses the std namespace for convenience, which allows the programmer to write cout instead of std::cout, etc. JavaScript does not have a similar feature.

---
