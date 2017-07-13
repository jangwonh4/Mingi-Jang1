using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_S2017_Lesson9B
{
    public class SuperVillain : SuperHuman, IHasMalice
    {

        private int _malice;


        public int Malice
        {
            get
            {
                return this._malice;
            }

            set
            {
                this._malice = value;
            }
        }

        public SuperVillain(string name, int malice)
            : base(name)
        {
            this.Malice = malice;
        }
    }
}
