![1](./Images/1.png)

![2](./Images/2.png)

![3](./Images/3.png)

![4](./Images/4.png)

![5](./Images/5.png)

![6](./Images/6.png)

![7](./Images/7.png)

![8](./Images/8.png)

![9](./Images/9.png)

![10](./Images/10.png)

![11](./Images/11.png)

### visual studio 

* create project >> solution name & project name 

* right click on solution >> add>> create number of projects 

* In one solution containes number of projects

```hello.cs

using System; //console.writeline or read line already execueted //

namespace MyApp //objects classes or methods ni oka container loa place cheyatanni name space use cheastam, multiple features ni apply cheayalamtea a feacture ki a feature specific name estam//
{
    internal class Program ////
    {
        static void Main(string[] args) //main function//
        {
            Console.WriteLine("welcome to python life");
            
        }
    }
}

```
* class <classname>: collection of objects

* static:  with out object also we call's any class , variables and method (object used for calls var)

* void: don't expect the any output

* main: 

* string[]args :  zero args also program executes 

* Console.Write: print the output 

* Console.Writeline : print the output in next printed value



![12](./Images/12.png)

![13](./Images/13.png)

![14](./Images/14.png)

![15](./Images/15.png)

![16](./Images/16.png)

* string: string is a combination of charectores


```.cs
using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to python life");
            int a = 10;
            Console.WriteLine(a);
            float b = 23.5f;
            Console.WriteLine(b.GetType());
            bool n = true;
            Console.WriteLine(n.GetType());
            char c = 'a';
            Console.WriteLine('a'.GetType());
            string s = "welcome to c-sharp";
           // Console.WriteLine(s.GetType());
            Console.ReadLine(s.GetType());
            
        }
    }
}
```

![17](./Images/17.png)

![18](./Images/18.png)

![19](./Images/19.png)


![20](./Images/20.png)

![21](./Images/21.png)

![22](./Images/22.png)

![23](./Images/23.png)

![24](./Images/24.png)

![25](./Images/25.png)

* int identifier; (int: data type , identifier= variablename or value)

*  case = variables 

CASE ,case those are okay , but Case its not correct  

![26](./Images/26.png)

![27](./Images/27.png)

* int =datatype 

* B= variable

* value=56

![28](./Images/28.png)


![29](./Images/29.png)

![30](./Images/30.png)

![31](./Images/31.png)

![32](./Images/32.png)

```age.py
using System;
using System.Runtime.CompilerServices;
class program
{
    static void Main (string[] args)
    {
        variable();
    }
    static void variable()
    {
        int age = 30;
        Console.WriteLine("print age is{0} ",age);
        int age1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("age is {0} age1 is {1}", age , age1);
    }
}

o/p: 
print age is30
41
age is 30 age1 is 41
```

![33](./Images/33.png)

![34](./Images/34.png)

![35](./Images/35.png)

![36](./Images/36.png)

![37](./Images/37.png)

### one dimentional array

```
using System;
using System.Runtime.CompilerServices;
class program
{
    static void Main (string[] args)
    {
        array();
    }
    static void array()
    {
        int[] intArray1 = new int[5];
        foreach (int a in intArray1)
            Console.WriteLine(a + " ");
        Console.WriteLine();
        int[] intArray2 = new int[5] { 1,5,71,83,90};
        foreach(int b in intArray2)
            Console.WriteLine(b + " ");
        Console.WriteLine();
        int[] intArray3 = { 88, 22, 53 };
        Console.WriteLine("one Dimentional array :");
        foreach (int d in intArray3)
            Console.Write(d + " ");
        Console.WriteLine();       
    }
}
o/p:
0
0
0
0
0

1
5
71
83
90

one Dimentional array :
88 22 53
```

![38](./Images/38.png)

![39](./Images/39.png)

### 2 dimentional
```
using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        array();
    }

    static void array()
    {
        // Initialize a 2D array with dimensions [3, 2]
        int[,] _2D = new int[,] { { 3, 4 }, { 1, 4 }, { 2, 4 } };

        Console.WriteLine("2D array elements:");

        // Loop through the rows (3 rows)
        for (int i = 0; i < 3; i++)
        {
            // Loop through the columns (2 columns)
            for (int j = 0; j < 2; j++)
            {
                // Print the value at _2D[i, j]
                Console.Write(_2D[i, j] + " ");  // Using a space to separate the values in each row
            }
            Console.WriteLine();  // Move to the next line after printing each row
        }
    }
}

o/p:
2D array elements:
3 4
1 4
2 4
```

### 3 dimentional

```
using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        array();
    }

    static void array()
    {
        int[,,] _3D = new int[,,] { { { 1, 2, 3 }, { 2, 3, 4 }, { 3, 4, 5 }, { 4, 5, 6 } } };

        Console.WriteLine("3D elements:");
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 3; j++)
                for (int k = 0; k < 3; k++)
            {
                // Access the elements properly
                Console.WriteLine($"i = {i}, j = {j}, k = {k},value = {_3D [i, j,k]}");
            }
        }
        Console.WriteLine();
    }
}

o/p:
3D elements:
i = 0, j = 0, k = 0,value = 1
i = 0, j = 0, k = 1,value = 2
i = 0, j = 0, k = 2,value = 3
i = 0, j = 1, k = 0,value = 2
i = 0, j = 1, k = 1,value = 3
i = 0, j = 1, k = 2,value = 4
i = 0, j = 2, k = 0,value = 3
i = 0, j = 2, k = 1,value = 4
i = 0, j = 2, k = 2,value = 5
```

![40](./Images/40.png)

### jagged array

```
using System;

class Program
{
    static void Main(string[] args)
    {
        array();
    }

    static void array()
    {
        // Initialize the jagged array
        int[][] J_A = new int[2][];
        J_A[0] = new int[5] { 1, 5, 4, 8, 9 };
        J_A[1] = new int[4] { 2, 2, 6, 7 };  // This sub-array has 4 elements

        Console.WriteLine("Jagged array elements:");

        // Iterate through each array in the jagged array
        for (int i = 0; i < J_A.Length; i++)
        {
            Console.WriteLine("Array " + i + ":");

            // Iterate through each element in the i-th array
            for (int j = 0; j < J_A[i].Length; j++)
            {
                Console.WriteLine("Element [" + i + "," + j + "] = " + J_A[i][j]);
            }
        }
    }
}

Jagged array elements:
Array 0:
Element [0,0] = 1
Element [0,1] = 5
Element [0,2] = 4
Element [0,3] = 8
Element [0,4] = 9
Array 1:
Element [1,0] = 2
Element [1,1] = 2
Element [1,2] = 6
Element [1,3] = 7

```

![41](./Images/41.png)

![42](./Images/42.png)

![43](./Images/43.png)

![44](./Images/44.png)

![45](./Images/45.png)

![46](./Images/46.png)

![47](./Images/47.png)

### arthematic , relational operators
```
using System;

class Program
{
    static void Main(string[] args)
    {
        operators();
    }
    static void operators()
    {
        int a = 25;
        int b = 5;
        Console.WriteLine(a + b);
        Console.WriteLine(a - b);
        Console.WriteLine(a / b);
        Console.WriteLine(a % b);
        Console.WriteLine(a * b);
        Console.WriteLine("relational operators");
        Console.WriteLine(a = b);
        Console.WriteLine(a < b);
        Console.WriteLine(a > b);
        Console.WriteLine(a <= b);

    }
       
}

o/p:
30
20
5
0
125
relational operators
5
False
False
True
```

### assignment operator

```
using System;

class Program
{
    static void Main(string[] args)
    {
        operators();
    }
    static void operators()
    {
        int a = 25;
        int b = 5;       
        Console.WriteLine("assignment  operators");       
        Console.WriteLine(a = b);
        Console.WriteLine(a += b);
        Console.WriteLine(a-= b);
    }
       
}
o/p:
assignment  operators
5
10
5

```
### increment operator
```
using System;

class Program
{
    static void Main(string[] args)
    {
        operators();
    }
    static void operators()
    {
        int a = 25;
        int b = 5;       
        Console.WriteLine("incrementt  operators");       
        Console.WriteLine(a = b);
        Console.WriteLine(a += b);
        Console.WriteLine(a-= b);

        Console.WriteLine(a++);
        Console.WriteLine(a);
        Console.WriteLine(++a);
    }
       
}
o/p:
incrementt  operators
5
10
5
5
6
7
```
### ternary operator
```
using System;

class Program
{
    static void Main(string[] args)
    {
        operators();
    }
    static void operators()
    {
        int a = 25;
        int b = 5;       
        Console.WriteLine("unary operator");
        Console.WriteLine(a > b ? b : a);
    }
       
}


o/p: incase a>b then its true ; prints b value 
unary operator
5
```
### logical operator

```
using System;

class Program
{
    static void Main(string[] args)
    {
        operators();
    }
    static void operators()
    {
        int a = 25;
        int b = 5;       
        Console.WriteLine("logical operator");
        Console.WriteLine(a > b && a < b);
        Console.WriteLine(a > b || a < b);
    }
       
}

o/p:
logical operator
False
True
```

### ternary operator

* not equalto true means it takes flase option automatically 

```
using System;

class Program
{
    static void Main(string[] args)
    {
        operators();
    }
    static void operators()
    {
        int a = 25;
        int b = 5;       
        Console.WriteLine("ternary operator");
        bool t = true;
        Console.WriteLine(!t);
    }
       
}

o/p:
ternary operator
False
```

![48](./Images/48.png)

![49](./Images/49.png)

![50](./Images/50.png)

![51](./Images/51.png)

![52](./Images/52.png)

![53](./Images/53.png)

![54](./Images/54.png)

![55](./Images/55.png)

![56](./Images/56.png)

### string

* String used as class (capital "S")

* string is a keyword (small "s")

* syntax:

        string[] variable_name = "value/text"

##### reference type

* once we enter the data , its not stored directly to the memory ; its saves the memory path where address file

##### immutable

* once we declare we cannot change another time


##### containes null:


##### i overloads the operator (==):

polymorphysum we used some over loading 



![57](./Images/57.png)

* to creating string using concadination one variable adds the another variable by using '+'  symbol

```.py
using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Strings();
        }
        static void Strings()
        {
            string a = "wecome to 42443";
             Console.WriteLine(a);
            
        }
    }
}
o/p:
wecome to 42443
```

```
using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Strings();
        }
        static void Strings()
        {
            string a = "wecome to 42443";
             Console.WriteLine(a);
            // array variable 
            string[] b = new string[4]; // we declare firt with array size
            b[0] = "hey ram";
            b[1] = "how are you yar";
            b[2] = "by the way this is your mobile! ";
            b[3] = "9966445588";
            for (int i = 0;i<4; i++)
                Console.WriteLine(b[i]);
            
        }
    }
} 
o/p:
wecome to 42443
hey ram
how are you yar
by the way this is your mobile!
9966445588
```
* we add some string byy using + symbole for concatiation (to modify )

```
using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Strings();
        }
        static void Strings()
        {
            string a = "wecome to 42443";
             Console.WriteLine(a);
            // array variable 
            string[] b = new string[4]; // we declare firt with array size
            b[0] = "hey ram";
            b[1] = "how are you yar";
            b[2] = "bythe way this is your mobile! ";
            b[3] = "9966445588";
            for (int i = 0;i<4; i++)
                Console.WriteLine(b[i]);

            // concotination 

            string abc = b[2] + b[1]+" is good";
            Console.WriteLine(abc);
            
        }
    }
}
o/p:
wecome to 42443
hey ram
how are you yar
bythe way this is your mobile!
9966445588
bythe way this is your mobile! how are you yar is good
```
```concadination
using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Strings();
        }
        static void Strings()
        {
            string a = "wecome to 42443";
             Console.WriteLine(a);
            // array variable 
            string[] b = new string[4]; // we declare firt with array size
            b[0] = "hey ram";
            b[1] = "how are you yar";
            b[2] = "bythe way this is your mobile! ";
            b[3] = "9966445588";
            for (int i = 0;i<4; i++)
                Console.WriteLine(b[i]);

            // concotination 

            string abc = b[2] + b[1]+" is good";
            Console.WriteLine(abc);
            int t = 100;
            string f = String.Format("{0}{1}", a, t.ToString());
            Console.WriteLine(f);
            
        }
    }
}
o/p:
wecome to 42443
hey ram
how are you yar
bythe way this is your mobile!
9966445588
bythe way this is your mobile! how are you yar is good
wecome to 42443100
```
```
using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Strings();
        }
        static void Strings()
        {
            Console.WriteLine("enter your name");
            string name = Console.ReadLine();
            Console.WriteLine(name);

        }
    }
}
o/p:
enter your name
<hema>
hema
```


*  create a string by Formate : in string class we have formate method , from this formate through also we  create a string ,

* by using for loops and creating the string (user-input)


![58](./Images/58.png)

![59](./Images/59.png)

![60](./Images/60.png)


![61](./Images/61.png)

![62](./Images/62.png)

* 

![63](./Images/63.png)

![64](./Images/64.png)

![65](./Images/65.png)

![66](./Images/66.png)

![67](./Images/67.png)

![68](./Images/68.png)

![69](./Images/69.png)

![70](./Images/70.png)


![71](./Images/71.png)

![72](./Images/72.png)

![73](./Images/73.png)

![74](./Images/74.png)

![75](./Images/75.png)

![76](./Images/76.png)

![77](./Images/77.png)

![78](./Images/78.png)

![79](./Images/79.png)

![80](./Images/80.png)

---

![81](./Images/81.png)

![82](./Images/82.png)

![83](./Images/83.png)

![84](./Images/84.png)

![85](./Images/85.png)

![86](./Images/86.png)

![87](./Images/87.png)

![88](./Images/88.png)

![89](./Images/89.png)

![90](./Images/90.png)


![91](./Images/91.png)

![92](./Images/92.png)

![93](./Images/93.png)

![94](./Images/94.png)

![95](./Images/95.png)

![96](./Images/96.png)

![97](./Images/97.png)

![98](./Images/98.png)

![99](./Images/99.png)

![100](./Images/100.png)

![01](./Images/01.png)

![02](./Images/02.png)

![03](./Images/03.png)

![04](./Images/04.png)

![05](./Images/05.png)

![06](./Images/06.png)

![07](./Images/07.png)

![08](./Images/08.png)

![09](./Images/09.png)

![10](./Images/10.png)


![011](./Images/011.png)

![012](./Images/012.png)

![013](./Images/013.png)

![014](./Images/014.png)

![015](./Images/015.png)

![016](./Images/016.png)

![017](./Images/017.png)

![018](./Images/018.png)

![019](./Images/019.png)

![021](./Images/021.png)

![022](./Images/022.png)

![023](./Images/023.png)

![024](./Images/024.png)

![025](./Images/025.png)

![026](./Images/026.png)

![027](./Images/027.png)

![028](./Images/028.png)

![029](./Images/029.png)

![030](./Images/030.png)

<br>

![031](./Images/031.png)

![032](./Images/032.png)

![033](./Images/033.png)

![034](./Images/034.png)

![035](./Images/035.png)

![036](./Images/036.png)

![037](./Images/037.png)

![038](./Images/038.png)

![039](./Images/039.png)

![040](./Images/040.png)

