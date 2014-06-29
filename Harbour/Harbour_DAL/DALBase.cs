using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;


namespace Harbour_DAL
{
    public class DALBase
    {
        protected HarbourChargingEntities entities = new HarbourChargingEntities();
    }
}
