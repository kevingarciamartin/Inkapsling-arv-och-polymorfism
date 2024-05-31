using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inkapsling__arv_och_polymorfism.Polymorfism
{
    public class DeleteDataBaseError : UserError
    {
        public override string UEMessage()
        {
            return "You tried to delete the data base. This fired an error!";
        }
    }
}
