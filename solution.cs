Here is a JavaScript console application that manually implements a call stack to simulate recursion iteratively. This example uses a factorial function as an example of a recursive function.

```javascript
function Stack() {
    this.stack = [];
}

Stack.prototype.push = function(value) {
    this.stack.push(value);
}

Stack.prototype.pop = function() {
    if (this.stack.length === 0) {
        return 'Underflow';
    }
    return this.stack.pop();
}

Stack.prototype.peek = function() {
    return this.stack[this.stack.length - 1];
}

Stack.prototype.isEmpty = function() {
    return this.stack.length === 0;
}

function factorial(n) {
    let stack = new Stack();
    while (true) {
        while (n > 1) {
            stack.push(n--);
        }
        let result = 1;
        while (!stack.isEmpty()) {
            result *= stack.pop();
        }
        return result;
    }
}

console.log(factorial(5)); // Output: 120
```

This program creates a Stack class with push, pop, peek, and isEmpty methods. The factorial function uses this Stack class to simulate recursion iteratively. It pushes all numbers from n to 1 onto the stack, then multiplies them together to calculate the factorial.