using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_quang.tt.Entity
{
    public class Category : BaseRow
    {
        public Category(int id, string name)
       : base(id, name)
        {
        }
        public override string ToString()
        {
            return $"Category ID: {id}, Name: {name}";
        }
    }
}
