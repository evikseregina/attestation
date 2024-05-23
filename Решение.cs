string [] NewArr(string [] array)
{
    
    string [] StringArr2 = new string [array.Length];
    for (int i = 0;  i < array.Length; i++) 
    {
       
        if (array[i].Length <= 3)
        {
          
            StringArr2[i] = array[i];
           
        }
        
    }
    return StringArr2;
}

void ShowArray (string [] array)
{
    foreach (string e in array)
    {
        Console.Write($"{e} ");
    }
}

string [] StringArr = ["Hell0", ":-)", "-2", "world!"];
 string[] result = NewArr(StringArr);
ShowArray(result);