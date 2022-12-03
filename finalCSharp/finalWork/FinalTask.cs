
//1. Создание массива через ввод юзером своих значений. 
string[] addArray()
{

  Console.Write($"Введи кол-во элементов массива:\t");

  int elmCount = int.Parse(Console.ReadLine());

  string[] myArray = new string[elmCount];

  for (int i = 0; i < myArray.Length; i++)
  {
    Console.WriteLine($" \n Введи значение для {i}-го элемента массива: ");
    myArray[i] = Console.ReadLine();
  }

  return myArray;

}

// 2. Вывод на экран массива, созданного юзером
void printBaseArray(string[] myArray)
{
  Console.WriteLine($" \n Массив, созданный юзером: ");

  Console.Write($"[");
  for (int i = 0; i < myArray.Length; i++)
  {
    Console.Write($" {myArray[i],1} ");
  }
  Console.Write($"] \n");

  Console.WriteLine(" \n ============== ");
}

//3. Ф-ция формирования массива из строк, длина которых <=3
void createSecondArr(string[] myArray)
{
  string[] addNewArray = new string[myArray.Length];

  Console.Write($"Массив, в котором длинна строк не более 3 символов:\n");

  Console.Write($"[");
  for (int i = 0; i < myArray.Length; i++)
  {

    if (myArray[i].Length <= 3)
    {
      addNewArray[i] = myArray[i];
      Console.Write($" {addNewArray[i],1} ");
    }
  }
  Console.Write($"] \n");

  Console.WriteLine(" \n ============== ");

}


// вызов ф-ции по первичному созданию массива
string[] firstArray = addArray();

// вывод на экран введенного юзером Массива 
printBaseArray(firstArray);

// вызов ф-ции для выполнения условий задачи. Печать идет из ф-ции
createSecondArr(firstArray);

 

