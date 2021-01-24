using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZKTeco.Shared;

namespace ZKTeco.Interface
{
    public interface IDashboardRepo
    {
        public ItemDetail GetProductsDetatil();
        public ItemDetail GetServicesDetatil();
        public ItemDetail GetEventsDetatil();
        public ItemDetail GetNewsDetatil();
        public ItemDetail GetContactUsDetatil();
        public ItemDetail GetSupportOnlionDetatil();
    }
}
