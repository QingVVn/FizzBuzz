namespace FizzBuzz
{
    public class NoFilter : Filter
    {
        public override string Results(int number)
        {
            return number.ToString();
        }

        public override bool Verify(int number)
        {
            return true;
        } 
    }
}