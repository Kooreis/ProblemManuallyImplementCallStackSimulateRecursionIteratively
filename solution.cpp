```cpp
#include <iostream>
#include <stack>

using namespace std;

void printStack(stack<int> s)
{
    while (!s.empty())
    {
        cout << ' ' << s.top();
        s.pop();
    }
    cout << '\n';
}

void simulateRecursion(int n)
{
    stack<int> s;
    while (true)
    {
        while (n > 0)
        {
            s.push(n--);
        }

        if (s.empty())
        {
            break;
        }

        n = s.top();
        s.pop();
        printStack(s);
    }
}

int main()
{
    int n = 5;
    simulateRecursion(n);
    return 0;
}
```