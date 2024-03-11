int[] array = {1, 12, 64, 93, 26, 59, 82, 82};

int n = array.Length;
int find = 82;

int index = 0;

while(index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}

