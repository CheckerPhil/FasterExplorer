using System.IO;

public class FileExplorer
{
    public void fileExplorer(){
        
        while(true){
            string[] files = Directory.GetFiles(Directory.GetCurrentDirectory());
            string[] folders =  Directory.GetDirectories(Directory.GetCurrentDirectory());
            int i = 0;

            Console.Clear();
            foreach(string folder in folders){
                i++;
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("+" + i.ToString()+ folder.Replace(Directory.GetCurrentDirectory() + "/", "") + "|");
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
            }else if(input.StartsWith("-")){
                try{
                    if(input.Length > 1){
                        var inputa = input.ToCharArray();
                        Directory.SetCurrentDirectory(folders[Convert.ToInt32(Char.GetNumericValue(inputa[1])) - 1]);
                    }else{
                        Directory.SetCurrentDirectory(folders[0]);
                    }
                    continue;
                }catch(Exception e){
                    if(e is IndexOutOfRangeException){
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("No Folder found.");
                        Console.ResetColor();
                    }
                }
            }else if(input.StartsWith("+")){
                try{
                    Directory.SetCurrentDirectory("..");
                    if(input.Length > 1){
                        var inputa = input.ToCharArray();
                        Console.WriteLine(Char.GetNumericValue(inputa[1]));
                        Directory.SetCurrentDirectory(folders[Convert.ToInt32(Char.GetNumericValue(inputa[1]))]);
                    }
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