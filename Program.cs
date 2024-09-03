namespace Operators_reload
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            CPoint p1 = new CPoint { x = 10, y = 10 };
            CPoint p2 = new CPoint { x = 10, y = 10 };

            CPoint p3 = p1;

            Console.WriteLine($"ReferenceEquals(p1, p2) {ReferenceEquals(p1, p2)}");
            Console.WriteLine($"ReferenceEquals(p1, p3) {ReferenceEquals(p1, p3)}");

            SPoint sp1 = new SPoint { x = 10, y = 10 };
            SPoint sp2 = new SPoint { x = 10, y = 10 };

            SPoint sp3 = sp1;

            Console.WriteLine($"ReferenceEquals(sp1, sp2) {ReferenceEquals(sp1, sp2)}");
            Console.WriteLine($"ReferenceEquals(sp1, sp3) {ReferenceEquals(sp1, sp3)}");

            Console.WriteLine($"Equals (sp1, sp2) {Equals(sp1, sp2)}");
            Console.WriteLine($"Equals (sp1, sp2) {Equals(sp1, sp3)}");
            */
            /*
            Employee employee1 = new Employee("Ivan", 50000, new DateTime(1991, 1, 1));
            Employee employee2 = new Employee("Pyotr", 100000, new DateTime(1992, 2, 2));

            employee1 = employee1 + 10000;
            employee2 = employee2 - 5000;
            bool areEqual = employee1 == employee2;
            bool isLess = employee1 < employee2;
            bool isGreater = employee1 > employee2;
            bool areObjectsEqual = employee1.Equals(employee2);
            */

            Matrix matrix1 = new Matrix(3, 3) { [0, 0] = 1, [0, 1] = 2, [0, 2] = 3, 
                                                [1, 0] = 4, [1, 1] = 5, [1, 2] = 6, 
                                                [2, 0] = 7, [2, 1] = 8, [2, 2] = 9 };
            Matrix matrix2 = new Matrix(3, 3) { [0, 0] = 10, [0, 1] = 11, [0, 2] = 12, 
                                                [1, 0] = 13, [1, 1] = 14, [1, 2] = 15, 
                                                [2, 0] = 16, [2, 1] = 17, [2, 2] = 18 };

            // Сложение матриц
            Matrix sum = matrix1 + matrix2;

            // Вычитание матриц
            Matrix difference = matrix1 - matrix2;

            // Умножение матрицы на число
            Matrix scaledMatrix = matrix1 * 2;

            // Умножение матриц друг на друга
            Matrix product = matrix1 * matrix2;

            // Проверка на равенство матриц
            bool areEqual = matrix1 == matrix2;

            // Проверка на неравенство матриц
            bool areNotEqual = matrix1 != matrix2;


        }
    }
}
