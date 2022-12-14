# Question: How do you rotate a 2D matrix by 90 degrees in-place? JavaScript Summary

The JavaScript code provided defines a function named `rotateMatrix` that rotates a 2D matrix by 90 degrees in-place. The function begins by determining the length of the matrix and its midpoint. It then uses two nested loops to rotate the elements of the matrix. The outer loop iterates over each layer of the matrix, starting from the outermost layer and moving towards the innermost layer. The inner loop iterates over each element within the current layer, swapping it with the corresponding element in the next layer. This process of swapping elements is done in a circular manner, which effectively rotates the matrix. The function then returns the rotated matrix. The code also includes a test case where a 2D matrix is defined and the function is called to rotate this matrix. The result of this operation is then printed to the console.

---

# TypeScript Differences

The TypeScript version of the solution solves the problem in a similar way to the JavaScript version. Both versions use the same algorithm to rotate the matrix in-place by swapping elements in a circular manner. 

However, there are a few differences between the two versions:

1. TypeScript uses static typing: In the TypeScript version, the `rotate` method explicitly declares that its parameter `matrix` is an array of arrays of numbers (`number[][]`). This provides type safety, which can help prevent bugs and improve the development experience with features like autocompletion and compile-time checks.

2. Use of classes: The TypeScript version wraps the `rotate` function inside a `MatrixRotator` class. This is more of a design choice rather than a language feature difference. JavaScript also supports classes, but the JavaScript version of the solution chose to implement the function standalone.

3. Return type: The JavaScript version of the function returns the rotated matrix, while the TypeScript version does not return anything (`void`). This is because the TypeScript version is designed to modify the input matrix in-place, and it assumes that the caller will use the modified input matrix after calling the `rotate` method.

4. Variable naming: The TypeScript version uses `temp` as the temporary variable for swapping elements, while the JavaScript version uses `k`. This doesn't affect the functionality, but `temp` might be a more descriptive name.

5. Calculation of loop boundaries: The TypeScript version calculates the boundaries of the inner loop slightly differently from the JavaScript version. The JavaScript version uses `y - i` as the upper boundary, while the TypeScript version uses `n - i - 1`. Both versions effectively do the same thing, but the TypeScript version might be slightly more readable because it directly uses `n`, the size of the matrix.

---

# C++ Differences

The C++ version of the solution uses the same logic as the JavaScript version to solve the problem. Both versions use two nested loops to iterate over the matrix and swap elements in a circular fashion to achieve the rotation. 

However, there are some differences due to the language features and syntax of C++ and JavaScript:

1. Data Structure: In JavaScript, the matrix is represented as an array of arrays. In C++, the matrix is represented as a vector of vectors.

2. Function Definition: In JavaScript, the function is defined using the `function` keyword, while in C++, the function is defined using the `void` keyword indicating that the function does not return anything.

3. Variable Declaration: In JavaScript, variables are declared using the `let` keyword. In C++, variables are declared with their data type, such as `int` for integers.

4. Size of Matrix: In JavaScript, the size of the matrix is obtained using the `length` property. In C++, the size of the matrix is obtained using the `size()` method.

5. Printing: In JavaScript, the matrix is printed using the `console.log` function. In C++, the matrix is printed using the `std::cout` object and the `<<` operator.

6. Main Function: In C++, the main function `int main()` is required as the entry point of the program. In JavaScript, there is no such requirement.

7. Return Statement: In JavaScript, the rotated matrix is returned by the function. In C++, the function does not return anything, and the matrix is modified in-place.

8. In C++, the matrix is passed by reference to the function, which allows the function to modify the original matrix. In JavaScript, objects and arrays are always passed by reference, so the original matrix is modified as well.

---
