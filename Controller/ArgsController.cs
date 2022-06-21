public class ArgsController
{
    public void checkInput(String[] input){
        switch(input[0]){ 
            case "m":
                Move m = new Move();
                m.move(input);
                break;
            case "n":
                NewFile n = new NewFile();
                n.create(input);
                break;
            case "d":
                Delete d = new Delete();
                d.delete(input);
                break;
            case "c":
                Copy c = new Copy();
                c.copy(input);
                break;
        } 
    }
}