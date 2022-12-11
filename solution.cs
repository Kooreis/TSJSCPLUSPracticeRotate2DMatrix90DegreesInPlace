Here is a JavaScript solution for rotating a 2D matrix by 90 degrees in-place:

```javascript
function rotateMatrix(matrix) {
    const n = matrix.length;
    const x = Math.floor(n/ 2);
    const y = n - 1;
    for (let i = 0; i < x; i++) {
        for (let j = i; j < y - i; j++) {
            let k = matrix[i][j];
            matrix[i][j] = matrix[y - j][i];
            matrix[y - j][i] = matrix[y - i][y - j];
            matrix[y - i][y - j] = matrix[j][y - i]
            matrix[j][y - i] = k
        }
    }
    return matrix;
}

let matrix = [[1, 2, 3], [4, 5, 6], [7, 8, 9]];
console.log(rotateMatrix(matrix));
```

This script defines a function `rotateMatrix` that takes a 2D matrix as input and rotates it 90 degrees in-place. The function first calculates the length of the matrix and the mid-point of the matrix. It then uses two nested loops to swap the elements of the matrix in a circular fashion. The outer loop iterates over each layer of the matrix, from the outermost layer to the innermost layer. The inner loop iterates over each element in the current layer, swapping it with the corresponding element in the next layer. The function finally returns the rotated matrix. The script then defines a 2D matrix and prints the result of rotating this matrix.