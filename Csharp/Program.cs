//class cat
//{
//    string? name;
//    string? color;
//    int age;

//    public cat(string name, string color, int age)
//    {
//        this.name = name;
//        this.color = color;
//        this.age = age;
//    }

//     static void Main(string[] args)
//    {
//        cat cat1 = new cat("Tom", "Black", 3);
//        cat cat2 = new cat("Jerry", "White", 2);
//        cat cat3 = new cat("Spike", "Brown", 5);
//        cat cat4 = new cat("Tuffy", "Grey", 1);
//        Console.WriteLine("Cat1: " + cat1.name + " " + cat1.color + " " + cat1.age);
//        Console.WriteLine("Cat2: " + cat2.name + " " + cat2.color + " " + cat2.age);
//        Console.WriteLine("Cat3: " + cat3.name + " " + cat3.color + " " + cat3.age);    
//        Console.WriteLine("Cat4: " + cat4.name + " " + cat4.color + " " + cat4.age);
//    }
//}
class Time
{
    private int hour;
    private int minute;
    private int second;
    private int Date;
    private int Month;
    private int Year;
    private int Day;
    public int Hour
    {
        get { return hour; }
        set { hour = value; }
    }
    public int Minute
    {
        get { return minute; }
        set { minute = value; }
    }   
    public int Second
    {
        get { return second; }
        set { second = value; }
    }
    public int date
    {
        get { return Date; }
        set { Date = value; }
    }
    public int month
    {
        get { return Month; }
        set { Month = value; }
    }
    public int year
    {
        get { return Year; }
        set { Year = value; }
    }
    public int day
    {
        get { return Day; }
        set { Day = value; }
    }





    public Time()
    {
        hour = 0;
        minute = 0;
        second = 0;
    }
    public Time(int h, int m, int s)
    {
        hour = h;
        minute = m;
        second = s;
    }
    public void Display()
    {
        Console.WriteLine("Time: " + hour + ":" + minute + ":" + second);
    }


}


