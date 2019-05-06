namespace FizzBuzz
{
    public class BuzzFilter : Filter
    {
        public override string Results(int number)
        {
            return "Buzz";
        }

        public override bool Verify(int number)
        {
            return number % 5 == 0 || number.ToString().Contains("5");
        } 
    }
}