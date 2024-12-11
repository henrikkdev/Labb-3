namespace Labb_3
{ 
    class program
    {
        static void Main(string[] args)
        {
            TempertureAnalyzer analyzer = new TempertureAnalyzer();

            //Temp för varje dag.
            analyzer.Printdateandtemp();

            //Medeltemp
            analyzer.PrintAverageTemperature();
        
            //max temp
            analyzer.GetMaxTemp();
            
            //min temp
            analyzer.GetMinTemperature();

            //Median
            analyzer.PrintMedianTemp();
        }
        
    }
    
}
