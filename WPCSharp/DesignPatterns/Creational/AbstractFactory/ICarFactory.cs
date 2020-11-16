namespace WPCSharp.DesignPatterns.Creational.AbstractFactory
{
    internal interface ICarFactory
    {
        ISedan ManufactureSedan(string segment);
        ISuv ManufactureSuv(string segment);
    }
}