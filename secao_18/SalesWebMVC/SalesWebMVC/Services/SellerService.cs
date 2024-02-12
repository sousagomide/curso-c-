﻿using SalesWebMVC.Data;
using SalesWebMVC.Models;

namespace SalesWebMVC.Services {
    public class SellerService {

        private readonly SalesWebMVCContext _context;

        public SellerService(SalesWebMVCContext context) {
            _context = context;
        }

        public List<Seller> FindAll() {
            return _context.Sellers.ToList();
        }

        public void Insert(Seller obj) {
            obj.Department = _context.Department.First();
            //Console.WriteLine(obj.Name);
            //Console.WriteLine(obj.Id);
            _context.Add(obj);
            _context.SaveChanges();

        }
    }
}
