using System;

// --- POOR CODE QUALITY SCRIPT (WHAT MAKES IT POOR?) ---
class Activity2
{
    static void Main(string[] args)
    {
        int x=0;string s="";
        while(true){
                Console.Write("what is it? ");
                string a=Console.ReadLine();
                if(a=="exit"){
                  break;
                }
                else{
                      Console.Write("type: ");
                      string b=Console.ReadLine();
                      Console.Write("time: ");
                      int c=int.Parse(Console.ReadLine());
                      x=x+c;s=s+"Task: "+a+" | Cat: "+b+" | Mins: "+c+"\n";
                      Console.WriteLine("saved");
                }
        }
        Console.WriteLine("\n--- DAILY WORK LOG ---");
        Console.WriteLine(s);
        Console.WriteLine("----------------------------");
        Console.WriteLine("Total Duration: "+x+" minutes");
    }
}
