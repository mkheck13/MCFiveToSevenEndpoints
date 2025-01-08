namespace MCFiveToSevenEndpoints.Services
{
    public class ReverseItNumServices
    {
        public string reverseNum(string input)
        {
            string revNumOut = "";
            bool isNum = int.TryParse(input, out int num);

            if (isNum)
            {
                for (int i = num.ToString().Length - 1; i >= 0; i--)
                {
                    revNumOut += num.ToString()[i];
                }
                return $"{input} reversed is {revNumOut}";
            }
            else
            {
                return $"{input} is not a number";
            }
        }
    }
}