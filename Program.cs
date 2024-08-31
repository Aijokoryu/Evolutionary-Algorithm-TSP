using Evolutionary_Algorithm_TSP;

Console.WriteLine("Hello, World!");
/*
 XMLdata = filename of the tsp you'd like to try 
 (if you want you can add more sample data from http://comopt.ifi.uni-heidelberg.de/software/TSPLIB95/tsp/ in the
 XMLData folder)
 Generations = how "long" the programm is creating new paths.
 Mutation probability = the chance to swap to swap random pathparts.
 crossoveramount = how often each population path should be split up, before it gets re-arranged (can influence the runtime)
 */

Tsp tsp = new Tsp("burma14.xml", 100_000, 70,100,4);
tsp.GenerateSolution();
//readkey to not end the programm immediatly
Console.ReadKey();