public class InputController
{
    public void checkInput(String input){
        String[] inputs = input.Split(' ');
        if(inputs[0].StartsWith("::")){
            try{
                String ntp = input.Substring(2,1);
                int n = Int32.Parse(ntp);
                
                SetDirectory.DirectoryPath[n] = inputs[1];
            }catch(Exception e){
                Console.WriteLine(e);
            }

        }else{
            switch(inputs[0]){ 
            case "m":
                Move m = new Move();
                m.move(inputs);
                break;
            case "n":
                NewFile n = new NewFile();
                n.create(inputs);
                break;
            case "d":
                Delete d = new Delete();
                d.delete(inputs);
                break;
            case "c":
                Copy c = new Copy();
                c.copy(inputs);
                break;
            case "fe":
                FileExplorer fe = new FileExplorer();
                fe.fileExplorer(inputs);
                break;
            case "q":
                Environment.Exit(0);
                break;
            } 
        } 
    }
}