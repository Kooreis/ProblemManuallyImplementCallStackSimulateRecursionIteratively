Here is a TypeScript console application that manually implements a call stack to simulate recursion iteratively. This example uses the factorial function as an example of recursion.

```typescript
class Stack<T> {
    private items: T[] = [];

    push(item: T) {
        this.items.push(item);
    }

    pop(): T | undefined {
        return this.items.pop();
    }

    isEmpty(): boolean {
        return this.items.length === 0;
    }
}

class Factorial {
    private stack: Stack<number>;

    constructor() {
        this.stack = new Stack<number>();
    }

    calculate(n: number): number {
        this.stack.push(n);

        let result = 1;
        while (!this.stack.isEmpty()) {
            const top = this.stack.pop();
            if (top === 1 || top === 0) {
                continue;
            }
            result *= top;
            this.stack.push(top - 1);
        }

        return result;
    }
}

const factorial = new Factorial();
console.log(factorial.calculate(5));  // Output: 120
```

This program creates a `Stack` class for managing the stack operations. Then it creates a `Factorial` class that uses a `Stack` to simulate the recursive calculation of a factorial. The `calculate` method pushes the initial number onto the stack, then enters a loop that continues until the stack is empty. In each iteration of the loop, it multiplies the result by the top number on the stack, then pushes the next lower number onto the stack. When the stack is empty, the result is the factorial of the original number.