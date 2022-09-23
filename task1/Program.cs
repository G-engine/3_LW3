using task1;

Vector v1 = new Vector(1,2,3);
Vector v2 = new Vector(2,3,1);
Vector v3 = new Vector();

v3 = v1 + v2;

if (v1 == v2)
    v3.Print();
else
    Console.WriteLine("Error");