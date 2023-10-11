using System.IO;
using System.Linq;

public class DeleteDirectoy
{
    public void delete(String[] args){
        try{
            String name;
            if(args.Length <= 1){
                Console.Write("Name: ");
                name = Console.ReadLine();
            }else{
                if(args[1].StartsWith(":")){
                    String ntp = args[1].Substring(1,1);
                    int n = Int32.Parse(ntp); 

                    name = SetDirectory.DirectoryPath[n];
                }else if(args[1].All(char.IsDigit)){
                    string[] files = Directory.GetFiles(Directory.GetCurrentDirectory());
                    string[] folders =  Directory.GetDirectories(Directory.GetCurrentDirectory());

                    name = folders[Int32.Parse(args[1]) - 1];
                }else{
                    name = args[1];
                }
            }
            if(Directory.Exists(name)){
                Directory.Delete(name);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Succesfully deleted {0}", name);
                Console.ResetColor();
            }else{
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("ERROR: File does not exist!");
                Console.ResetColor();
            }
        }catch(Exception e){
            Console.WriteLine(e);
        }
    }
}