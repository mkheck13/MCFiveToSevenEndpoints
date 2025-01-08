namespace MCFiveToSevenEndpoints.Services
{
    public class OddOrEvenServices
    {
        public string oddOrEven(int num)
        {
            if(num % 2 == 0)
            {
                return $"{num} appears to be even.";
            }else{
                return $"{num} appears to be odd.";
            }
        }
    }
}