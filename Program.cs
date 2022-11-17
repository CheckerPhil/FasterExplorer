public class Program 
{ 
    public static void Main(String[] args){
        if(args.AsQueryable().FirstOrDefault() != null){
            ArgsController ct = new ArgsController();
            ct.checkInput(args);
        }else{
                FileExplorer fe = new FileExplorer();
                fe.fileExplorer();
        }
      
    }    
}
