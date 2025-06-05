Console.WriteLine("Введите размерность матрицы");

int n;
while (!(int.TryParse(Console.ReadLine(), out n))) {
    Console.WriteLine("Вы ввели не те данные.");
}

int[,] matrix = new int[n, n];
int num = 1;

for (int d = 0; d < 2 * n - 1; d++) {
    
    int r;
    int c;

    if (d < n) {
        r = 0;
        c = d;
    } else { 
        r = d - n + 1;
        c = n - 1;
    }

    if (d % 2 == 0) {
        for (int i = r, j = c; i < n && j >= 0; i++, j--) {
            matrix[i, j] = num++;
        }
    }
    else {
        for (int i = c, j = r; i >= 0 && j < n; i--, j++) {
            matrix[i, j] = num++;
        }
    }
}

for (int i = 0; i < n; i++) {
    for (int j = 0; j < n; j++) {
        Console.Write($"{matrix[i, j],4}");
    }
    Console.WriteLine();
}
