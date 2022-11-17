using System.IO;

public class Move
{
    public void move(String[] args){
        try{
            if(args.Length <= 1){
                Console.Write("Name 1: ");
                args[1] = Console.ReadLine();
                Console.Write("Name 2: ");
                args[2] = Console.ReadLine();
            }
            File.Move(args[1], args[2]);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Succesfully moved {0} to {1}", args[1], args[2]);
            Console.ResetColor();
        }catch(Exception e){
            Console.WriteLine(e);
        }
    }
}
  