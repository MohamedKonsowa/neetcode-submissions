public class Solution
{

    public string Encode(IList<string> strs)
    {
        StringBuilder sb = new StringBuilder();
        int digitsCount;
        foreach (string str in strs)
        {
            digitsCount = str.Length == 0 ? 1 : (int)Math.Log10(Math.Abs((double)str.Length)) + 1;

            sb.Append(digitsCount);
            sb.Append(str.Length);
            sb.Append(str);
        }

        return sb.ToString();
    }

    public List<string> Decode(string s)
    {
        int l = s.Length;
        int i = 0;
        int digitsCount;
        int subStrLen;

        List<string> list = new List<string>();


        while (i < l)
        {
            digitsCount = s[i] - '0';

            subStrLen = int.Parse(s.Substring(i + 1, digitsCount));


            list.Add(s.Substring(i + 1 + digitsCount, subStrLen));
            i += subStrLen + 1 + digitsCount;
        }

        return list;
    }
}