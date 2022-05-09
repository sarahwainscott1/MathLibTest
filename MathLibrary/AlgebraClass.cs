namespace MathLibrary {
    public class AlgebraClass {
        public static double Inverse(double a) {
            if (a == 0) { Console.WriteLine("a cannot be 0"); }
            return 1 / a;
        }
        public static int Modulo(int a, int b) {
            if (b == 0) { Console.WriteLine("b cannot be 0"); }
            return a % b;
        }
        public static long Cubed(int a) {
            return a * a * a;
        }
        public static int Function(int a) {
            return (a * a) + (3 * a) + 5;
        }
    }
}