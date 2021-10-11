using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class IncomesTest
    {
        public void Receipts_Success()
        {
            BusinessLayer1.Incomes incomes = new BusinessLayer1.Incomes();
            bool informedValue = incomes.Cancelation(1);
            Assert.IsTrue(informedValue);

        }
    }
}
