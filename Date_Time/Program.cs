// See https://aka.ms/new-console-template for more information
using System;

DateTime dt = new DateTime();

var now = DateTime.Now;

Console.WriteLine($"current time = {now.Hour}");

Console.WriteLine(now.ToLongDateString());

Console.WriteLine(now.ToShortDateString());

Console.WriteLine(now.ToShortTimeString());

Console.WriteLine(now.ToLongTimeString());

Console.WriteLine( now.ToString("yyyy:MM:dd") );

TimeSpan ts = new TimeSpan(1,2,3);

Console.WriteLine(ts);

var ts1 = TimeSpan.FromHours(1);

Console.WriteLine(ts1);

Console.WriteLine($"minutes = {ts.Minutes}");

Console.WriteLine($"add ={ts.Add(TimeSpan.FromMinutes(1))}");