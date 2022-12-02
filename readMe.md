# Итоги блока. Выбор специализации

**Мотивационная картинка 1:**
 
> [my GitHub](https://github.com/trenersambo)

**Описание контрольной работы**

1. Блок №1

```C#

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

```

***Метод addArray***

* предлагает пользователю ввести размер массива (кол-во элементов) ;

* int.Parse преобразует строку (string) в int (если может) ;

* задаем массив myArray с размерностью, указанной юзером ;

* перебирая массив, на каждой итерации предлагаем ввести в консоли произвольное строковое значение для каждого элемента ;

* в завершении возвращем полученное значение массива myArray (для последующей его печати на экране / вывод в консоль);


_________
<br>

2. Блок №2

```C#

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

```

***Метод printBaseArray***

* принимает переданный аргумент в виде массива;

* вывод на экран каждого элемента, проитерировав массив в цикле for ;

_________
<br>

3. Блок №3

```C#
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

```

***Метод createSecondArr***

* принимает переданный аргумент в виде массива;

* создаем новый массив createSecondArr, куда будем складывать полученные значения в соответствии с условиями задачи;

* с целью обработать каждое значение массива, запускаем цикл for ;

* внутри цикла применяем условие if, при помощи которого сверяем длинну значения каждого i-го элемента массива createSecondArr с условием равным трём; 

* если условие 'true', тогда добавляем в новый массив addNewArray каждое значение, удовлетворившее условию;

_________
<br>

4. Блок №4

```C#
// вызов ф-ции по первичному созданию массива
string[] firstArray = addArray();

// вывод на экран введенного юзером Массива 
printBaseArray(firstArray);

// вызов ф-ции для выполнения условий задачи. Печать идет из ф-ции
createSecondArr(firstArray);

```

В этом блоке вызываем методы, подставляя внутрь параматер в виде переменной firstArray. 

<br>
__________________

<br>

> [my GitHub](https://github.com/trenersambo)