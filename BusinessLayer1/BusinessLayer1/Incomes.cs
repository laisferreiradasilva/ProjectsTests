using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer1
{
    public class Incomes
    {
        public bool Receipts(int valor)
        {
            if(valor <=0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool Devolution(int valor)
        {
            if (valor >0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool Cancelation(int valor)
        {
            if(valor > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public bool Shipping(int valor)
        {
            if(valor > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
