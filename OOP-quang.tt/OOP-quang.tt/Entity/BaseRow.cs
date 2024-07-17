using OOP_quang.tt.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_quang.tt.Entity
{
    public abstract class BaseRow : IEnity
    {
        public int id { get; set; }
        public string name { get; set; }

        protected BaseRow(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

        public void PrintRow()
        {
            throw new NotImplementedException();
        }
    }
}
