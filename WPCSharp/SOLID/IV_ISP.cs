using System;

namespace WPCSharp.SOLID.I
{
    public interface IPdfFormatter
    {
        void ToPdf();
    }
    public interface IExcelFormatter
    {
        void ToExcel();
    }

    public class Report : IPdfFormatter, IExcelFormatter
    {
        public void ToExcel()
        {
            Console.WriteLine("Generating Excel...");
        }

        public void ToPdf()
        {
            Console.WriteLine("Generating Pdf...");
        }
    }

    public class Poem : IPdfFormatter
    {
        public void ToPdf()
        {
            Console.WriteLine("Generating Pdf...");
        }
    }
}
