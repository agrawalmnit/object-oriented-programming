// a static contructor is used to perform the action that
// needs to be performed only once.
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp40
{
    public class Static
    {
        protected static readonly DateTime globalStartTime;

        protected int RouteNumber { get; set; }

        static Static()
        {
            globalStartTime = DateTime.Now;

            Console.WriteLine("global start timeset statically to  {0}", globalStartTime.ToLongTimeString());


        }


        public Static(int routeNum)
        {

            RouteNumber = routeNum;

            Console.WriteLine("Bus {0} is created", RouteNumber);
        }

        public void Drive()
        {

            TimeSpan elapsedTime = DateTime.Now - globalStartTime;

            Console.WriteLine("{0} is starting its route {1:N2} minutes after global start time {2}:", this.RouteNumber, elapsedTime.Milliseconds, globalStartTime.ToShortDateString());
        }
    }

    class TestStatic
    {
        static void Main()
        {

            Static Static1 = new Static(71);

            Static Static2 = new Static(72);

            Static1.Drive();

            System.Threading.Thread.Sleep(25);

            Static2.Drive();

            Console.WriteLine("press any key to exit");

            Console.ReadKey();
        }
    }
}
