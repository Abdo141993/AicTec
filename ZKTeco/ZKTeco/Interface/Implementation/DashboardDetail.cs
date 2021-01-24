using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZKTeco.Models;
using ZKTeco.Shared;

namespace ZKTeco.Interface.Implementation
{
    public class DashboardDetail : IDashboardRepo
    {
        private readonly ZKTecoDbContext _context;

        public DashboardDetail(ZKTecoDbContext context)
        {
            _context = context;
        }
        public ItemDetail GetProductsDetatil()
        {
            return new ItemDetail()
            {
                Count = (_context.Products.ToList()).Count
            };
        }
        public ItemDetail GetServicesDetatil()
        {
            return new ItemDetail()
            {
                Count = (_context.Services.ToList()).Count
            };
        }
        public ItemDetail GetEventsDetatil()
        {
            return new ItemDetail()
            {
                Count = (_context.Events.ToList()).Count
            };
        }
        public ItemDetail GetNewsDetatil()
        {
            return new ItemDetail()
            {
                Count = (_context.News.ToList()).Count
            };
        }

        public ItemDetail GetContactUsDetatil()
        {
            return new ItemDetail()
            {
                Count = (_context.ContactUs.ToList()).Count
            };
        }

        public ItemDetail GetSupportOnlionDetatil()
        {
            return new ItemDetail()
            {
                Count = (_context.OnlineSupports.ToList()).Count
            };
        }
    }
}
