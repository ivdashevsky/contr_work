string [] Array = /*{"Russia","Denmark","Kazan"};*/ /*{"1234","1567","-2","computer "};*/ {"Hello", "2", "World", ":-)"};
int count = 0;
int final_count = 0;


for (int i = 0; i < Array.Length; i++)
{
    if (Array[i].ToString().Length <= 3)
    {
        final_count++;
    }

}

string [] result = new string [final_count];

for (int i = 0; i < Array.Length; i++)
{
    if (Array[i].ToString().Length <= 3)
    {
        result[count] = Array[i];
        count++;
    }
}

Console.WriteLine(String.Join(" ",result));