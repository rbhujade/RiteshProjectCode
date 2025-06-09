// See https://aka.ms/new-console-template for more information

using Singleton;

// Thread Safe with double null check
ThreadSafetySingleton singleton = ThreadSafetySingleton.Instance;
Console.WriteLine("First Time");
ThreadSafetySingleton singleton1 = ThreadSafetySingleton.Instance;
Console.WriteLine("Second Time");


// Lazy Singleton
LazySingleton lazySingleton = LazySingleton.Instance;
Console.WriteLine("First Time");
var lazySingleton1 = LazySingleton.Instance;
Console.WriteLine("Second Time");

Console.ReadLine();



