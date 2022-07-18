using System.IO;

public class FileExplorer
{
    public void fileExplorer(String[] args){
        
        while(true){
            string[] files = Directory.GetFiles(Directory.GetCurrentDirectory());
            string[] folders =  Directory.GetDirectories(Directory.GetCurrentDirectory());
            
            Console.Clear();
            Console.WriteLine("Faster Explorer: fe");
            foreach(string folder in folders){
                Console.WriteLine("+" + folder.Replace(Directory.GetCurrentDirectory() + "/", "") + "|");
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
                Console.WriteLine(Directory.GetCurrentDirectory() + folders[0] +"/");
                Directory.SetCurrentDirectory(folders[0]);
                continue;
            }
            else{
                InputController ct = new InputController();
                ct.checkInput(input);
            }
        }
    }
}