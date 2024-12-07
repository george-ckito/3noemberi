using _3noemberi;
//1
if(false)
{
    Building building = new Building(3, 4, 5);
    building.ShowData();
    House house = new House(3, 4, 5, 6, 7.5);
    house.ShowData();
}

//2
if (false)
{
    Triangle triangle = new Triangle(3, 4, 5);
    triangle.ShowData();
    Rectangle rectangle = new Rectangle(3, 4);
    rectangle.ShowData();
}

//3
if(false)
{
    FixedEmployee fixedEmployee = new FixedEmployee("John", "Doe", "2309423840", 1000);
    fixedEmployee.ShowData();
    DynamicEmployee dynamicEmployee = new DynamicEmployee("Jane", "Doe", "2309423840", 1000, 38);
    dynamicEmployee.ShowData();
}

//4
if(false)
{
    Car car = new Car();
    car.left();
    car.right();
    car.start();
    car.stop();
}

//5
if (false)
{
    FullTime ft = new FullTime("john", 500);
    PartTime pt = new PartTime("doe", 45, 17.5);
    ft.GetInfo();
    pt.GetInfo();
}

//6
if (false)
{
    Email email = new Email("iodjoasjdoasidj@aodjsa.sad", "siajdias@dasidj.sadas", "hi");
    email.send("ksa@dsa.sad");
    email.receive();
    Sms sms = new Sms("234234233", "32432432423", "hello");
    sms.send("234234234");
    sms.receive();
}