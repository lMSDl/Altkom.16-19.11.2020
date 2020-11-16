namespace WPCSharp.DesignPatterns.Creational.AbstractFactory
{
    internal class Order
    {
        private readonly ICar _car;

        public Order(ICarFactory carFactory, string type, string segment)
        {
            switch (type)
            {
                case nameof(ISedan):
                    _car = carFactory.ManufactureSedan(segment);
                    break;
                case nameof(ISuv):
                    _car = carFactory.ManufactureSuv(segment);
                    break;
            }
        }

        public string ManufacturedCarName()
        {
            return _car.Name();
        }
    }
}