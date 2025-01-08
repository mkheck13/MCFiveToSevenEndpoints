using Microsoft.AspNetCore.Components.Forms;

namespace MCFiveToSevenEndpoints.Services
{
    public class ReverseItNumServices
    {
        public string ReverseNum(string input)
        {
            int revNumOut = 0;
            bool isTrue = int.TryParse(input, out int num);
            if(isTrue)
            {
                while(num != 0)
                {
                    revNumOut = revNumOut * 10 + (num % 10);
                    num = num / 10;
                }
            }
            else
            {
                return "Please enter a number and try again.";
            }
            return $"{input} reversed is {revNumOut}";
        }
    }
}