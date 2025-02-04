using Co_ContraVarience;

delegate Vehicle delveh();
delegate void delcontra(Car car);
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        Vehicle vhl = new Vehicle();
        delveh delv = new delveh(vhl.CreateVehicle);

        Car cr = new Car();
    
        delv = new delveh(cr.CreateCar);

        delcontra delcont = new delcontra(vhl.Display);
        delcont.Invoke(cr);

        delcont += cr.DisplayCar;

    }
}
