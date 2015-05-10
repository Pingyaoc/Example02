using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example02
{
    class Employee
    {
        private string _工號;
        private string _姓名;

        public string 姓名
        {
            get { return _姓名; }
            set { _姓名 = value; }
        }
        public string 工號
        {
            set
            {
                _工號 = value;
            }
            get
            {
                return this._工號;
            }
        }

    }
}
