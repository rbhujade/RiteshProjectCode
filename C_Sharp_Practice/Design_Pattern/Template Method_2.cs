using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern
{
    public abstract class DataExporter
    {
        public void Export()
        {
            Connect();
            FetchData();
            FormatData();
            SaveToFile();
        }

        protected abstract void Connect();
        protected abstract void FetchData();
        protected abstract void FormatData();

        protected virtual void SaveToFile()
        {
            Console.WriteLine("Saving data to file..");
        }
    }

    public class CSVDataExporter : DataExporter
    {
        protected override void Connect()
        {
            Console.WriteLine("Connect to database");
        }

        protected override void FetchData()
        {
            Console.WriteLine("Fetch data from database.");
        }

        protected override void FormatData()
        {
            Console.WriteLine("Format data as CSV.");
        }
    }
}
