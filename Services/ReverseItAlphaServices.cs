namespace MCFiveToSevenEndpoints.Services
{
    public class ReverseItAlphaServices
    {
        public string reverseAlpha(string input)
        {
            string reverseWord = "";
            for (int i = input.Length - 1; i >= 0; i--)
            {
                reverseWord += input[i];
            }
            return $"{input} reversed is {reverseWord}";
        }
    }
}