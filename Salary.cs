using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example02
{
    class Salary
    {
        private int BaseSalary;
        private int Benefit;

        public int 基本薪資 
        {
            set
            {
                this.BaseSalary = value;
                if (value < 0)
                    this.BaseSalary = 0;
                else if (value > 22000)
                    this.BaseSalary = 22000;
                else
                    this.BaseSalary = value;
            }
            get
            {
                return this.BaseSalary;
            }
        }       
        public int 獎金
        {
            set
            {
                this.Benefit = value;
                if (value < 0)
                    this.Benefit = 0;
                else if (value > 15000)
                    this.Benefit = 15000;
                else
                    this.Benefit = value;
            }
            get 
            {
                return this.Benefit;
            }
        }

    }
}
