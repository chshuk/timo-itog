string[] arrayStr = {"Hello","Rus", "'Russia'", "oct", ";-)", "combo", "min"};

List<string> new_array = new List<string>();

for(int i = 0; i < arrayStr.Length; i++)
{
    if (arrayStr[i].Length <= 3)
    {
        new_array.Add(arrayStr[i]);
    }
}

foreach (string Element in new_array)
{
    Console.Write(Element + ',');
}
