// Написать программу, которая из имеющегося массива строк формирует новый массив 
// из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно 
// ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не 
// рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

string[] stringArray = new string[4] { "Hello", ":)", "world", "2" };
string[] newArray = new string[4];
int count = 0;
for (int j = 0; j < stringArray.Length; j++)
{
    string item = stringArray[j];

    for (int i = 0; i < item.Length; i++)
    {
        count++;
    }

    if (count <= 3)
    {
        newArray[j] = stringArray[j];
    }
    count = 0;
}




