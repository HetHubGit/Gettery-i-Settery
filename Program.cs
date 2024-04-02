internal class Program
{
    public static void main(String[] args) 
    {
       
      
    int i = 0;
    int z = 0;
    double ce;
    int j = -1;
    double x;
    Boolean exit = false;
        while (!exit){
            ce = (double.Parse(Console.ReadLine()));
            i++;
            if (ce == j){
                i--;
                x = (double)z / i;
    Console.WriteLine(x);
                break;
            }else z = (int)(z + ce);
            
        }

    }
}
