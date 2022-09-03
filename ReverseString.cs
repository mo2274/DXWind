

/// <summary>
/// The run time of the function will be O(N) where N is the length of the input string.
/// The space complexity of the function will be O(N) where N is the length of the input string.
/// </summary>
string ReverseString(string s)
{
    string temp = "";
    string result = "";
    string finalResult = "";


    // reverse the string by extracting words seperated by spaces and add them in reverse order
    for (int i = 0; i < s.Length; i++)
    {
        if (s[i] == ' ')
        {
            result = temp + " " + result;
            temp = "";
            continue;
        }

        if (i == s.Length - 1)
        {
            temp += s[i];
            result = temp + " " + result;
        }

        temp += s[i];
    }


    // remove the last space
    for (int i = 0; i < result.Length - 1; i++)
    {
        finalResult += result[i];
    }

    return finalResult;
}