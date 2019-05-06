namespace FizzBuzz
{
    public class FizzBuzzFilter : Filter
    {
        public override string Results(int number)
        {
            return "FizzBuzz";
        }

        public override bool Verify(int number)
        {
            return number % 15 == 0;
        } 
    }
}