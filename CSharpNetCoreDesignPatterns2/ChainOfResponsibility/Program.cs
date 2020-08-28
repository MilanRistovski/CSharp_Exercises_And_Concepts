using System;

namespace ChainOfResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            var mechanic = new Mechanic();
            var detailler = new Detailler();
            var wheels = new WheelSpecialist();
            var qa = new QualityControl();

            qa.SetNextServiceHandler(detailler);
            wheels.SetNextServiceHandler(qa);
            mechanic.SetNextServiceHandler(wheels);

            Console.WriteLine("Car 1 is dirty!");
            mechanic.Service(new Car { Requirements = ServiceRequirements.Dirty });
            Console.WriteLine();
            Console.WriteLine("Car 2 requires full service");
            mechanic.Service(new Car { Requirements = ServiceRequirements.Dirty | ServiceRequirements.EngineTune | ServiceRequirements.TestDrive | ServiceRequirements.WheelAlignment });
            Console.ReadLine();
        }
    }
    [Flags]
    enum ServiceRequirements
    {
        None = 0,
        WheelAlignment = 1,
        Dirty = 2,
        EngineTune = 4,
        TestDrive = 8
    }

    class Car
    {
        public ServiceRequirements Requirements { get; set; }
        public bool IsServiceComplete { get; }
    }
    abstract class ServiceHandler
    {
        protected ServiceHandler _nextServiceHandler;
        protected ServiceRequirements _servicesProvided;
        public ServiceHandler(ServiceRequirements servicesProvided)
        {
            _servicesProvided = servicesProvided;
        }
        public void Service(Car car)
        {
            if (_servicesProvided == (car.Requirements & _servicesProvided))
            {
                Console.WriteLine($"{this.GetType().Name} providing {this._servicesProvided} services");
                car.Requirements &= ~_servicesProvided;
            }
            if (car.IsServiceComplete || _nextServiceHandler == null)
                return;
            else _nextServiceHandler.Service(car);
        }
        public void SetNextServiceHandler(ServiceHandler handler)
        {
            _nextServiceHandler = handler;
        }
    }
    class Detailler : ServiceHandler
    {
        public Detailler() : base(ServiceRequirements.Dirty) { }
    }
    class Mechanic : ServiceHandler
    {
        public Mechanic() : base(ServiceRequirements.EngineTune) { }
    }
    class WheelSpecialist : ServiceHandler
    {
        public WheelSpecialist() : base(ServiceRequirements.WheelAlignment) { }
    }
    class QualityControl : ServiceHandler
    {
        public QualityControl() : base(ServiceRequirements.TestDrive) { }
    }
}
