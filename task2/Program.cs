using task2;

CarsCatalog cars = new CarsCatalog(new Car("Ford Mustang", "V12", 280),
                                   new Car("Kia Sorento", "2.0 diesel - 300hp", 240),
                                   new Car("VAZ 2007", "1.6 - 90hp", 140));
                                   
Console.WriteLine(cars[2]);
Console.WriteLine(cars[1]);

Car c1 = new Car("Ford Mustang", "V12", 280);
Car c2 = new Car("Kia Sorento", "2.0 diesel - 300hp", 240);  
Console.WriteLine(c1.Equals(c2));