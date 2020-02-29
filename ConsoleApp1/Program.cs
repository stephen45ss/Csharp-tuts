using System;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {       a:
	        string filepath = "data.txt";
	    int loop = 1;
            while ( loop == 1 ) { 
            string a, b, c, d, e;
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
		Console.WriteLine("Date of Birth: ");
		d = Console.ReadLine();
		Console.WriteLine("Social Security Number:");
		e = Console.ReadLine();
	    Console.WriteLine("Data successfully added to database!");
            if (!File.Exists(filepath)){
	    using (StreamWriter file = File.CreateText(filepath))
	    {
		    file.WriteLine("Employees: ");
		    if (c == "female" || c == "f" || c == "Female"){
			    using (StreamReader mn = new StreamReader("maiden.txt"))
			    {
				    string hmm = mn.ReadLine();
				    file.WriteLine(a + " " + b + "/" + hmm + " F " + d + " " + e);
			    }
			    File.Delete("maiden.txt");
	    goto b;}
	    else {
	    file.WriteLine(a + " " + b + " M " + d + " " + e); 
	    goto b;}
	    }}
		    using (StreamWriter file = File.AppendText(filepath))
	    { 
		     if (c == "female" || c == "f" || c == "Female"){
			     using (StreamReader mn = new StreamReader("maiden.txt"))
			     {
				    string hmm = mn.ReadLine();
				     file.WriteLine(a + " " + b + "/" + hmm + " F " + d + " "+ e);
			     } 
			      File.Delete("maiden.txt");
			      goto b;}
		     else {
		    file.WriteLine(a + " " + b + " M " + d + " " + e); 
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
