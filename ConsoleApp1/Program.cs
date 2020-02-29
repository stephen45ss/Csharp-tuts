using System;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {       a:
	        string filepath = "hello.txt";
	    int loop = 1;
            while ( loop == 1 ) { 
            string a, b, c;
            string mname;
            Console.WriteLine("Male or female?");
	    c = Console.ReadLine();
	    Console.WriteLine("First Name: ");
            a = Console.ReadLine();
            Console.WriteLine("Last Name: ");
            b = Console.ReadLine();
	    if (c == "female" || c == "f" || c == "Female"){
	    Console.WriteLine("Maiden Name: ");
	    mname = Console.ReadLine();
	    using(StreamWriter hmm = File.CreateText("maiden.txt"))
	    { hmm.WriteLine(mname);}
	    goto c;
	    }
	    else { goto c; }
	c:
	    Console.WriteLine("The name " + a + " " + b + " was added to our database!");
            if (!File.Exists(filepath)){
	    using (StreamWriter file = File.CreateText(filepath))
	    {
		    file.WriteLine("Names: ");
		    if (c == "female" || c == "f" || c == "Female"){
			    using (StreamReader mn = new StreamReader("maiden.txt"))
			    {
				    string hmm = mn.ReadLine();
				    file.WriteLine(a + " " + b + ":" + hmm );
			    } 
	    goto b;}
	    else {
	    file.WriteLine(a + " " + b + " "); 
	    goto b;}
	    }}
		    using (StreamWriter file = File.AppendText(filepath))
	    { 
		     if (c == "female" || c == "f" || c == "Female"){
			     using (StreamReader mn = new StreamReader("maiden.txt"))
			     {
				    string hmm = mn.ReadLine();
				     file.WriteLine(a + " " + b + ":" + hmm );
			     } 
			      goto b;}
		     else {
		    file.WriteLine(a + " " + b + " "); 
		     goto b; } }
	b:
	    string choice;
            Console.WriteLine("Continue?");
            choice = Console.ReadLine();
            if (choice == "continue" | choice == "c")
            {
                goto a;
            }
            else
            {
                Environment.Exit(0);
            }
           }
	}}}
