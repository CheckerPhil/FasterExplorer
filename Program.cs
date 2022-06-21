public class Program 
{ 
    public static void Main(String[] args){
        if(args.AsQueryable().FirstOrDefault() != null){
            ArgsController ct = new ArgsController();
            ct.checkInput(args);
        }else{
            while(true){
                Console.Write("Faster Explorer: ");
                String input = Console.ReadLine();
                InputController ct = new InputController();
                ct.checkInput(input);
            }
        }
      
    }    
}
