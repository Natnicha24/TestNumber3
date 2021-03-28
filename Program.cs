using System;

namespace Number3
{
    class Program
    {
        static void Main(string[] args)
        {
            int Nbox1, Nbox2, Nbox3,NumberofBucketA,NumoftakingoutboxA, NumberofBucketB, NumoftakingoutboxB;
            Nbox1 = int.Parse(Console.ReadLine());
            Nbox2 = int.Parse(Console.ReadLine());
            Nbox3 = int.Parse(Console.ReadLine());
            do
            {
                NumberofBucketA = int.Parse(Console.ReadLine());
                NumoftakingoutboxA = int.Parse(Console.ReadLine());
                switch (NumberofBucketA)
                {
                    case 1:
                        Nbox1 = Nbox1 - NumoftakingoutboxA;
                        break;
                    case 2:
                        Nbox2 = Nbox2 - NumoftakingoutboxA;
                        break;
                    case 3:
                        Nbox3 = Nbox3 - NumoftakingoutboxA;
                        break;
                    default:
                        break;
                }
                if(Nbox1==0&& Nbox2 == 0 && Nbox3 == 0 )
                {
                    Console.WriteLine("\nB");
                }
                else {
                NumberofBucketB = int.Parse(Console.ReadLine());
                NumoftakingoutboxB = int.Parse(Console.ReadLine());
                switch (NumberofBucketB)
                {
                    case 1:
                        Nbox1 = Nbox1 - NumoftakingoutboxB;
                            break;
                    case 2:
                        Nbox2 = Nbox2 - NumoftakingoutboxB;
                            break;
                    case 3:
                        Nbox3 = Nbox3 - NumoftakingoutboxB;
                            break;
                    default:
                        break;
                }
                    if (Nbox1 == 0 && Nbox2 == 0 && Nbox3 == 0)
                    {
                        Console.WriteLine("\nA");
                    }
                }
            } while (Nbox1 != 0 || Nbox2 != 0 || Nbox3 != 0);
            Console.ReadLine();
        }
    }
}
