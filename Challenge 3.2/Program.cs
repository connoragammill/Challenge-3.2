namespace Challenge_3._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
			Console.WriteLine(SumDigitsInString("1q2w3e"));//1+2+3=6
            Console.WriteLine(SumDigitsInString("L0r3m.1p5um"));//0+3+1+5=9 
            Console.WriteLine(SumDigitsInString(""));//there is no numbers so the sum would be 0 
		} 
        static int SumDigitsInString(string input) 
        { 
            int sum = 0; 
            foreach (char c in input) 
            { 
                if (char.IsDigit(c)) 
                { 
                    sum += int.Parse(c.ToString()); 
                } 
            }
            return sum;
		}
    }
}
