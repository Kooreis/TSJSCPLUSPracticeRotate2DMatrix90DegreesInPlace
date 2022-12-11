Here is a TypeScript solution for rotating a 2D matrix by 90 degrees in-place:

```typescript
class MatrixRotator {
    rotate(matrix: number[][]): void {
        const n = matrix.length;
        for (let i = 0; i < n / 2; i++) {
            for (let j = i; j < n - i - 1; j++) {
                let temp = matrix[i][j];
                matrix[i][j] = matrix[n - 1 - j][i];
                matrix[n - 1 - j][i] = matrix[n - 1 - i][n - 1 - j];
                matrix[n - 1 - i][n - 1 - j] = matrix[j][n - 1 - i];
                matrix[j][n - 1 - i] = temp;
            }
        }
    }
}

let matrix = [
    [1, 2, 3],
    [4, 5, 6],
    [7, 8, 9]
];

let rotator = new MatrixRotator();
rotator.rotate(matrix);

console.log(matrix);
```

This solution creates a class `MatrixRotator` with a method `rotate` that takes a 2D matrix and rotates it in-place. The rotation is performed by swapping elements in a circular manner for each layer of the matrix, starting from the outermost layer and moving inwards. The result is then printed to the console.