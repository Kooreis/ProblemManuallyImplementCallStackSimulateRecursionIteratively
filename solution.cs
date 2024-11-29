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