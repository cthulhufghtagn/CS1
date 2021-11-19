int x;
int y;

x = Convert.ToInt32(Console.ReadLine());
y = Convert.ToInt32(Console.ReadLine());

int a = Math.Abs (x) - Math.Abs(y);
int b = 1 + Math.Abs(y * x);
int equ = a / b;
Console.WriteLine ("equ: " + equ);