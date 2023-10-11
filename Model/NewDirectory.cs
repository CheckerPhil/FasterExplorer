using System.IO;

public class NewDirectory
{
    public void create(String[] args){
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
                }else{
                    name = args[1];
                }
                name = args[1];
            }
            if(!Directory.Exists(name)){
                Directory.CreateDirectory(name);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("File {0} succesfully created", name);
                Console.ResetColor();
            }else{
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("File already exists.");
                Console.Write("Replace (y/n)?");
                Console.ResetColor();
                String ans = Console.ReadLine();
                if(ans != "n"){
                    File.Create(name);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("File {0} succesfully created", name);
                    Console.ResetColor();
                }
            }
        }catch(Exception e){
            Console.WriteLine(e);
        }
    }
}