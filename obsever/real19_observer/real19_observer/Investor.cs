using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace real19_observer
{
    public class Investor : IInvestor  // <-- thêm : IInvestor
    {
        private string name;
        private Stock stock = null!; // dùng null! để hết warning CS8618

        public Investor(string name)
        {
            this.name = name;
        }

        public void Update(Stock stock)
        {
            Console.WriteLine($"Notified {name} of {stock.Symbol}'s change to {stock.Price:C}");
        }

        public Stock Stock
        {
            get { return stock; }
            set { stock = value; }
        }
    }
}
