using System.IO;

public class FileExplorer
{
    public void fileExplorer(){
        
        while(true){
            string[] files = Directory.GetFiles(Directory.GetCurrentDirectory());
            string[] folders =  Directory.GetDirectories(Directory.GetCurrentDirectory());
            
            Console.Clear();
            foreach(string folder in folders){
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("+" + folder.Replace(Directory.GetCurrentDirectory() + "/", "") + "|");
                Console.ResetColor();
            }
            foreach(string file in files){
                Console.WriteLine("-" + file.Replace(Directory.GetCurrentDirectory() + "/", ""));
            }
            
            Console.Write("Faster Explorer: ");
            String input = Console.ReadLine();
            if(input == "q"){
                break;
            }else if(input == "qq"){
                Environment.Exit(0);                
            }else if(input == "-"){
                try{
                    Directory.SetCurrentDirectory(folders[0]);
                    continue;
                }catch(Exception e){
                    if(e is IndexOutOfRangeException){
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("No Folder found.");
                        Console.ResetColor();
                    }
                }
            }else if(input == "+"){
                try{
                    Directory.SetCurrentDirectory("..");
                    continue;
                }catch(Exception e){
                    if(e is IndexOutOfRangeException){
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("No Folder found.");
                        Console.ResetColor();
                    }
                }
            }
            else{
                InputController ct = new InputController();
                ct.checkInput(input);
            }
        }
    }
}