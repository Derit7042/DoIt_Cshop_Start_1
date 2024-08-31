using System;

class Car
{
    private string name = null;
    private int speed = 0;

    public Car(string name)
    {
        this.name = name;
        Console.WriteLine("자동차의 이름은 " + name + "입니다.");
    }

    public void SetSpeed(int speed)
    {
        this.speed = speed;
    }

    public int GetSpeed()
    {
        return this.speed;
    }

    public void GoCar()
    {
        Console.WriteLine("자동차가 전진합니다.");
        Console.WriteLine("자동차의 속도는" + speed + "km 입니다.");
    }

    public void BackCar()
    {
        Console.WriteLine("자동차가 후진합니다.");
    }

    public void StopCar()
    {
        Console.WriteLine("자동차가 멈춥니다.");
    }

    ~Car()
    {
        Console.WriteLine(name + "자동차가 사라집니다.");
    }
}

class MainClass
{
    public static void Main(string[] args)
    {
        Car car = new Car("소나타");
        car.SetSpeed(80);
        car.GoCar();
        car.BackCar();
        car.StopCar();
    }
}