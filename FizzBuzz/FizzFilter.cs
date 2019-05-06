namespace FizzBuzz
{
    public class FizzFilter : Filter
    {
        public override string Results(int number)
        {
            return "Fizz";
        }

        public override bool Verify(int number)
        {
            return number % 3 == 0 || number.ToString().Contains("3");
        } 
    }
}