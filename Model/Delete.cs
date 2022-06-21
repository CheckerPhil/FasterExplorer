using System.IO;

public class Delete
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
                }else{
                    name = args[1];
                }
            }
            if(File.Exists(name)){
                File.Delete(name);
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