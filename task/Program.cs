Console.WriteLine("введите массив (можно числа, слова и знаки) запятую (пробел считается как часть элемента массива): ");
string String = Console.ReadLine() ?? "";
string[] result = ParseArray(String, ',');
string[] ParseArray(string input, char separator)
{
    string[] resultElements = new string[GetCountElementsInString(input)];
    int index = 0;
    string subString = String.Empty;
    int length = 0;
    for (int i = 0; i < input.Length; i++)
    {
        if (input[i] == separator)
        {
            resultElements[index++] = subString;
            length = subString.Length;
            if (length <= 3) Console.Write($"'{subString}' ");
            subString = String.Empty;
        }
        else
        {
            subString += input[i];
        }
    }
    resultElements[index] = subString;
    length = subString.Length;
    if (length <= 3) Console.Write($"'{subString}' ");
    return resultElements;
}
int GetCountElementsInString(string elements)
{
    int countElements = 1;
    for (int i = 0; i < elements.Length; i++)
    {
        if (elements[i] == ',')
            countElements++;
    }
    return countElements;

}
