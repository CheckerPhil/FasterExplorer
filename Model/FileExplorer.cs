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
                Console.WriteLine("+" + folder.Replace(Directory.GetCurrentDirectory() + "/", ""));
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
            }else{
                InputController ct = new InputController();
                ct.checkInput(input);
            }
        }
    }
}