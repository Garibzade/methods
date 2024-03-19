//namespace methods
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Arraydeki en kicik element =" + MinElements(12, -30, 14, 23));
//        }
//        public static int MinElements(params int[] elements)
//        {
//            int min = elements[0];
//            for (int i = 0; i < elements.Length; i++)
//            {
//                if (min > elements[i])
//                {
//                    min = elements[i];

//                }
//            }
//            return min;
//        }
//    }
//}

//-------------------------------------------------------------------------------------------------------------
//task2
namespace methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("cevrenin sahesi=" + Area(3));
            Console.WriteLine("duzbucaqlini sahesi="+Area(4,3));
            Console.WriteLine("paralepipedin sahesi="+Area(2,3,4));
            Console.WriteLine("ucbucagin daxilindeki cevrenin sahesi="+Area(3,4,2,1));
        }
        public static int Area(int r) 
        {
            int p = 3;
            int areaofcircle = p * r * r;
            return areaofcircle;
        }
        public static int Area(int a ,int b)
        {
            int areaofrectangular=a * b;
            return areaofrectangular;
        }
        public static int Area(int a,int b,int c)
        {
            int areaofparallelepiped = a * b + a * c + b * c;
            return areaofparallelepiped;
        }
        public static float Area( float r,float a,float b,float c)
        {   
            float p = (a + b + c) / 2;
            float ucbucaqdaxilindekicevreninsahesi = p * r;
            return ucbucaqdaxilindekicevreninsahesi;
        }
        
    }
}
