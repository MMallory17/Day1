//This line only


/*This comment 
 * goes on
 * multiple lines
 * */

//Creating variables
int myAge; 

myAge = 36;

int myAge2 = 36;
//Constant
const decimal TAXRATE = 0.6m;

//Getting iput from user
Console.WriteLine("Enter the radius");
//string entry = Console.ReadLine();
//int result = int.Parse(entry);
int result = int.Parse(Console.ReadLine());
double area = Math.PI * result * result;
Console.WriteLine(area);

//Math Section
double math1 = 1 + 2;
Console.WriteLine(math1);
double math2 = 1 - 2;
Console.WriteLine(math2);
double math3 = 1 * 2;
Console.WriteLine(math3);
double math4 = 1 / 2;
Console.WriteLine(math4);
double math5 = 1 % 2;
Console.WriteLine(math5);
Console.WriteLine(4 % 2 == 0);

//increment/decrement
int x = 1; 
Console.WriteLine(x);
x++; //x = x + 1
Console.WriteLine(x);
x--;
Console.WriteLine(x);

//assigning
int y = 5;
y += 3; //y = y + 3
Console.WriteLine(y);
y -= 4;
Console.WriteLine(y);
y /= 4;
Console.WriteLine(y);
y %= 1;
Console.WriteLine(y);
