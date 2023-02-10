namespace Product
{
    public class Product
    {
        /// <summary>
        /// this method calculates the root
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static double Mult(double num1, double num2) {
            double product;
            product = num1 * num2;

            Console.WriteLine("The product of {0} and {1} is: {2}", num1, num2, product);
            return product;
        }
    }
}