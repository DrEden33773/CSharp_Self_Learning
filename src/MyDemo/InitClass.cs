namespace CSharp_Self_Learning;

// default accessible status => protected
public class InitClass
{
    class DateDefination
    {
        uint year = 0;
        uint month = 0;
        uint day = 0;
        public DateDefination(uint year, uint month, uint day)
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }
        public void Output()
        {
            if (this.day == 0 || this.month == 0 || this.year == 0)
            {
                Console.WriteLine(
                    "This Class </DateDefination/> has not been initialized."
                );
            }
            Console.WriteLine(
                "The date => {2}/{1}/{0}", this.day, this.month, this.year
            );
        }
    }
    public static void Example()
    {
        var DateObj = new DateDefination(2022, 8, 4);
        DateObj.Output();
    }
}