using System;

namespace PropertiesCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Dollar dollar = new Dollar(1.99m);
            dollar.SetAmount(1.99m);//set
            Console.WriteLine(dollar.Amount);//get
            Console.WriteLine(dollar.isZero);//get
            Console.ReadKey();
        }
    }

    public class Dollar
    {
        private decimal _amount;

        public decimal Amount { get; set; }
        //public decimal Amount//Baking Feild
        //{
        //    get
        //    {
        //        return this._amount;
        //    }
        //  private  set
        //    {
        //        //Validation
        //        this._amount = ProcessValue(value);

        //        //if (value<=0)
        //        //{
        //        //    this._amount = 0;
        //        //}
        //        //else
        //        //{
        //        //    this._amount = value;
        //        //}

        //    }
        //} 

        public void SetAmount(decimal value)
        {
            _amount = value;
        }

        public bool isZero => _amount == 0;
        public decimal Conversionfactor { get; set; } = 1.99m;

        public Dollar(decimal amount)
        {
            this._amount = ProcessValue(amount);

            //if (amount<=0)
            //{
            //    this._amount = 0;
            //}
            //else
            //{
            //    this._amount = amount;
            //}

        }

        private decimal ProcessValue(decimal value) => value <= 0 ? 0 : Math.Round(value, 2); //Method Validation
    }


}
