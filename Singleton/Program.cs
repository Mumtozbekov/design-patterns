using Singleton;

President a = President.GetInstance();
President b = President.GetInstance();

Console.WriteLine(a == b); //Output : true