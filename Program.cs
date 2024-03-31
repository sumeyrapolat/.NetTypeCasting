//TYPE_CASTING

//Implicit Conversion;

byte a = 1;
sbyte b = 2;
short s = 3;
int i = a + b + s;

Console.WriteLine("i : " +i);

long l = i;
Console.WriteLine(l);

float f = l;
Console.WriteLine(f);

string sp = "sümeyrapolat";
char fd = 'a';
object o = sp + fd;
Console.WriteLine(o);   

//Explicit Conversion ;
Console.WriteLine("Explicit Conversion");

int tt = 127;
byte gg = (byte)tt;
Console.WriteLine(gg);

// String methodu
long mkt = 123456789;
string allnumbers = mkt.ToString();
Console.WriteLine(allnumbers);


float ff = 14.7f;
string ffstring = ff.ToString();    
Console.WriteLine(ffstring);

//System Convert 
string s1 = "1412", s2 = "1999";
int num1, num2;
int total;

num1 = Convert.ToInt32(s1);
num2 = Convert.ToInt32(s2);
total = num1 + num2;
Console.WriteLine(total);




