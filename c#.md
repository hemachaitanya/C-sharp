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

* IMPLICITE: small datatype converted to large data type(int a=10 ; string b = Convert.ToString(a);)

string = variable
Convert = class
toString = datatype

* EXPLICIT : large data type to small data type ()

![63](./Images/63.png)

![64](./Images/64.png)

![65](./Images/65.png)

![66](./Images/66.png)

```implicit no dataloss
using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TypeConversion();
        }
        static void TypeConversion()
        {
            int a = 10;
            float b = a;
            Console.WriteLine(b);
       

        }
    }
}
o/p:
10

```
```
using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TypeConversion();
        }
        static void TypeConversion()
        {
            float a = 43.47f;
            int b = Convert.ToInt32(a);
            Console.WriteLine(b);

        }
    }
}
//data loss will happends0.47
o/p:
43
```
```explicite(float-string)
using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TypeConversion();
        }
        static void TypeConversion()
        {
            float a = 43.47f;
            string s = Convert.ToString(a);
            Console.WriteLine("float to string conversion{0}",s);

        }
    }
}
o/p:
float to string conversion43.47
```

![67](./Images/67.png)

![68](./Images/68.png)

![69](./Images/69.png)

* ex: enter to the organization one condition is there ,  that is id card is needed

![70](./Images/70.png)


![71](./Images/71.png)
* when conditon is true the only its prints the value other wise condition is false o/p is null

```if
using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Control();
        }
        static void Control()
        {
            int a = 13;
            int b = 3;
            if (a>b)
            {
                Console.WriteLine("a is big");

            }
        }
    }
}
// condition true only prints the statemeno/p:
a is big
```
```
using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Control();
            Console.WriteLine("just learn c#");
        }
        static void Control()
        {
            int a = 13;
            int b = 3;
            if (a<b)
            {
                Console.WriteLine("b is big");

            }
            else
            {
                Console.WriteLine("a is big");
            }

        }
    }
}
o/p:
a is big
just learn c#
```

![72](./Images/72.png)

![73](./Images/73.png)
if a=3; b=1 ; c=4 at that time this condition not itterate s ;

```
using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Control();
            Console.WriteLine("just learn c#");
        }
        static void Control()
        {
            int a = 13;
            int b = 33;
            int c = 92;
            if (a > b)
            {
                Console.WriteLine("a is big");

            }
            else if (b > c) 
            {
                Console.WriteLine("b is big");
            }
            else
            {
                Console.WriteLine("c is big");
            }

        }
    }
}
o/p:
c is big
just learn c#
```


![74](./Images/74.png)

```
using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Control();
            Console.WriteLine("just learn c#");
        }
        static void Control()
        {
            int a = 43;
            int b = 53;
            int c = 92;
            if (a < b)
            {
                if (b < c)
                    Console.WriteLine("c is big ");
            }
            else if (b < c)
            {
                Console.WriteLine("b is big");
            }
            else
            {
                Console.WriteLine("c is big");
            }

        }
    }
}
o/p:
c is big
```



![75](./Images/75.png)

![76](./Images/76.png)

![77](./Images/77.png)

```
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a number between 1 and 5:");
        int number = int.Parse(Console.ReadLine());

        // Switch statement to evaluate the number
        switch (number)
        {
            case 1:
                Console.WriteLine("You entered One");
                break;
            case 2:
                Console.WriteLine("You entered Two");
                break;
            case 3:
                Console.WriteLine("You entered Three");
                break;
            case 4:
                Console.WriteLine("You entered Four");
                break;
            case 5:
                Console.WriteLine("You entered Five");
                break;
            default:
                Console.WriteLine("Invalid number! Please enter a number between 1 and 5.");
                break;
        }
    }
}
o/p:
Enter a number between 1 and 5:
3
You entered Three
```
```
using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Control();
            Console.WriteLine("Just learning C#");
        }

        static void Control()
        {
            int a = 43;
            int b = 93;
            int c = 92;

            // Correct the conditional logic
            if (a < b)
            {
                Console.WriteLine("a is less than b");
            }
            else if (b < c)
            {
                Console.WriteLine("b is less than c");
            }
            else
            {
                Console.WriteLine("None of the conditions matched");
            }

            Console.WriteLine("Enter a number (1 or 2):");
            int h = Convert.ToInt32(Console.ReadLine());

            // Switch statement based on the user's input
            switch (h)
            {
                case 1:
                    Console.WriteLine("You entered case 1");
                    break;
                case 2:
                    Console.WriteLine("You entered case 2");
                    break;
                default:
                    Console.WriteLine("Invalid input! Enter a valid number.");
                    break;
            }
        }
    }
}

o/p:
a is less than b
Enter a number (1 or 2):
2
You entered case 2
Just learning C#
```

![78](./Images/78.png)

![79](./Images/79.png)

![80](./Images/80.png)

```
using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Control();
        }

        static void Control()
        {
            int i = 0;
            while(i<3)
            {
                Console.WriteLine("while {0}", i);
                i++;
            }
        }
           
    }
}

o/p:
while 0
while 1
while 2
```

![81](./Images/81.png)


```
using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Control();
        }

        static void Control()
        {
            int i = 0;
            do
            {
                Console.WriteLine("while{0}", i);
                i++;
            }
            while (i < 3);
                
        }
           
    }
}

o/p:
while0
while1
while2
```
* in case we pass the condition wrongly then also loop not existed but first one statement is existed one time 

```
using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Control();
        }

        static void Control()
        {
            int i = 0;
            do
            {
                Console.WriteLine("while{0}", i);
                i++;
            }
            while (i < 0);
                
        }
           
    }
}
o/p:
while0
```

![82](./Images/82.png)
```
using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Control();
        }

        static void Control()
        {
           for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
                
        }
           
    }
}

o/p:
0
1
2
3
4
5
6
7
8
9
```

![83](./Images/83.png)
```
//nested for
using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Control();
        }

        static void Control()
        {
            // Correct 2D array initialization with 2 rows and 2 columns
            int[,] d = new int[,] { { 1, 2 }, { 1, 1 } };

            Console.WriteLine("Array values are:");

            // Loop through the rows of the array
            for (int i = 0; i < d.GetLength(0); i++)  // GetLength(0) gives the number of rows
            {
                // Loop through the columns of the array
                for (int j = 0; j < d.GetLength(1); j++)  // GetLength(1) gives the number of columns
                {
                    Console.WriteLine(d[i, j]); // Print each element
                }
            }
        }
    }
}

o/p:
Array values are:
1
2
1
1

```

![84](./Images/84.png)

```
//infinate loop
using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Control();
        }

        static void Control()
        {
                for (; ; )
                    Console.WriteLine("error");
            
        }
    }
}
o/p:
error
.....infinite times prints
```
* cntl+kc

* its used for multiple lines selected and commented at a time


![85](./Images/85.png)
```
using System;
namespace MyApp
{ 
    internal class Program
    {
        static void Main(string[] args)
        {A:
            Console.WriteLine("just learn c#");
            int f = 1;
            if (f == 1)
            {
                goto A;
            }
        }                  
    }
}
o/p:
just learn c#
..... infinate times its prints 
```

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

#### create class

* in name spaces we can create number of classes

* every classes access through attributes only

```
using System;
namespace python_life
{
    class Dog
    {
        public int a = 10;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dog crypto = new Dog();
            crypto.a++;
            Console.WriteLine(crypto.a);
          
        }
    }
}
o/p:
11
// with out crypto.a++;
o/p:
10

```

![03](./Images/03.png)

```
using System;
using System.Security.Cryptography.X509Certificates;
namespace python_life
{
    class Dog
    {
        public int a = 10;
        public void pet(string name, int age , string colur)
        {
            Console.WriteLine("pet name is:"+name +"age is"+age+"colour is" +colur);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dog crypto = new Dog();
            crypto.pet("puppy",5,"block");
          
        }
    }
}

o/p:
pet name is:puppyage is5colour isblock
```

![04](./Images/04.png)

![05](./Images/05.png)

![06](./Images/06.png)

![07](./Images/07.png)

![08](./Images/08.png)

![09](./Images/09.png)

![10](./Images/10.png)


![011](./Images/011.png)

* 
```
using System;
using System.Security.Cryptography.X509Certificates;
namespace python_life
{
    class program
    {
        static void Named(int a, int b)
        {
            Console.WriteLine("sum =" + (a + b));
        }
        static void Main(string[] args)
        {
            Named(a: 12, b: 2);
        }
    }
}
o/p:
sum = 14
```
### named parameter

```
using System;
using System.Security.Cryptography.X509Certificates;
namespace python_life
{
    class program
    {
        static void Named(int a, int b)
        {
            Console.WriteLine("sum =" + (a + b));
        }
        static void refs (ref int v1)
        {
            Console.WriteLine("Increment"+ ++v1);
        }
        static void Main(string[] args)
        {
            int v = 3;
            refs(ref v);
        }
    }
}
o/p:
Increment 4(here v =3 but ++3=4)
```

### with out initialization we passed the parameter

```
using System;
using System.Security.Cryptography.X509Certificates;
namespace python_life
{
    class program
    {
        static void Named(int a, int b)
        {
            Console.WriteLine("sum =" + (a + b));
        }
        static void outs(out int v)
        {
            v = 12;
            Console.WriteLine("Increment"+ ++v);
        }
        static void Main(string[] args)
        {
            int v = 5;
            outs(out v);
        }
    }
}
o/p:
increment13
```
#### default parameter

* sum will be printed two times firt time it takes 2 value 

next we gave only a, but b value already declared in int b=10


```
using System;
using System.Security.Cryptography.X509Certificates;
namespace python_life
{
    class program
    {
        static void Default(int a, int b =10)
        {
            Console.WriteLine("sum =" + (a + b));
        }
        static void outs(out int v)
        {
            v = 12;
            Console.WriteLine("Increment"+ ++v);
        }
        static void Main(string[] args)
        {
            int v = 5;
            Default(20, 2);
            Default(2);
             outs(out v);
            Console.WriteLine(v);
        }
    }
}

o/p:
sum =22
sum =12
Increment13
13

```

#### dynamic parametes 

* 
```
using System;
using System.Security.Cryptography.X509Certificates;
namespace python_life
{
    class program
    {
       static void dynmic(dynamic d)
           {
            int A=d*d;
            Console.WriteLine(A);
        }
        static void Main(string[] args)
        {
            dynmic(49);
            // where this value is stored

        }
    }
}

o/p:
2401
```

#### value parametes

* direct we pass the variables 

```
using System;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Markup;
namespace python_life
{
    class program
    {
       static void values( int a,int b)
        {
            Console.WriteLine("sum =" + (a+b));
        }
        static void Main(string[] args)
        {
            int c = 2, r = 4;
            values(c,r);
        }
            

        }
    }

o/p:
sum =6
```
#### params parameters

```
using System;

namespace python_life
{
    class Program
    {
        // Method to calculate the sum of two numbers
        static void values(int a, int b)
        {
            Console.WriteLine("sum = " + (a + b));
        }

        // Method to calculate the sum of an arbitrary number of integers
        static int add(params int[] num)
        {
            int s = 0;
            foreach (int i in num)
            {
                s = s + i;
            }
            return s;  // Return the sum
        }

        static void Main(string[] args)
        {
            // Call the add method with multiple integers
            int result = add(1, 5, 4, 7);
            Console.WriteLine("Total sum: " + result);  // Print the result
        }
    }
}

o/p:
Total sum: 17
```


![012](./Images/012.png)

![013](./Images/013.png)

![014](./Images/014.png)

![015](./Images/015.png)

![016](./Images/016.png)

![017](./Images/017.png)

![018](./Images/018.png)

![019](./Images/019.png)

![021](./Images/021.png)

##### default constructors

```
using System;

namespace python_life
{
    class demo
    {
        public demo()
        {
            Console.WriteLine("Default constructors");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("constructors");
            demo d = new demo();
            Console.ReadKey();
        }
    }
   
}

o/p:
constructors
Default constructors
```

![022](./Images/022.png)

#### parameterized constructors 
```

using System;

namespace python_life
{
    class Demo
    {
        // Parameterless constructor (optional)
        public Demo()
        {
            Console.WriteLine("No parameters constructor called.");
        }

        // Parameterized constructor
        public Demo(int a, int b)
        {
            Console.WriteLine("a + b = " + (a + b));
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Constructors:");

            // Create an instance using the parameterized constructor
            Demo d = new Demo(2, 4);

            // Optionally, you can create an instance using the parameterless constructor
            Demo d2 = new Demo();

            Console.ReadKey();
        }
    }
}


o/p:
Constructors:
a + b = 6
No parameters constructor c
```
#### private constructor 

* method is case sensitive i am facing issue is main not accept , Main

```

using System;

namespace python_life
{
    class demo
    {
        private demo()
        {
            Console.WriteLine("private constructor");
        }
        public static void CreateInstance()
        {
            demo demoObject = new demo();
        }
    }
        class program
        {
            public static void Main(string[] args)
            {
                demo.CreateInstance();
                Console.ReadKey();
            }
        }
     
    }
        



o/p:
private constructor
```
#### copy constructor

```

using System;
using System.Security.AccessControl;
using Microsoft.VisualBasic;

namespace python_life
{
    class Program
    {
        private string month;
        private int year;
        public Program(Program s)
        {
            month = s.month;
            year = s.year;
        }
        public Program(string month, int year)
        {
            this.month = month;
            this.year = year;
        }
        public string Details
        {
            get
            {
                return "Month: " + month.ToString() + "\nYear: " + year.ToString();
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("copyinstructor");
            Program g1 = new Program("June", 2018);
            Program g2 = new Program(g1);
            Console.WriteLine(g2.Details);
            Console.ReadKey();

        }
    }
}
o/p:
copyinstructor
Month: June
Year: 2018
```
* above programe 

* this = keyword

* 2 parameters calls from using one object calls other parameter


![023](./Images/023.png)

![024](./Images/024.png)

![025](./Images/025.png)

![026](./Images/026.png)

![027](./Images/027.png)

![028](./Images/028.png)

![029](./Images/029.png)

![030](./Images/030.png)


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

