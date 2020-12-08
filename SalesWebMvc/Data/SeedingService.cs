using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesWebMvc.Data;
using SalesWebMvc.Models;
using SalesWebMvc.Models.Enums;

namespace SalesWebMvc.Data
{
    public class SeedingService
    {
        private SalesWebMvcContext _context;

        public SeedingService(SalesWebMvcContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if (_context.Department.Any() || _context.Seller.Any() || _context.SalesRecord.Any())
            {
                return; //DB já foi populado
            }
            Department d1 = new Department(1, "Computadores");
            Department d2 = new Department(2, "Essas mais de mesa");
            Department d3 = new Department(3, "Livros");
            Department d4 = new Department(4, "Moda");


            Seller s1 = new Seller(1, "Roberto G", "robertin@gmail.com", new DateTime(1998, 4, 21),1000.0,d1);
            Seller s2 = new Seller(2, "Rosangela A ", "rsGAGA@gmail.com", new DateTime(1995, 10, 31),3100.0,d2);
            Seller s3 = new Seller(3, "Pedro Y", "pedrinUNDERGROUND@gmail.com", new DateTime(2001, 1, 12),900.0,d3);
            Seller s4 = new Seller(4, "Emaculada Q", "meudeus@gmail.com", new DateTime(1700, 9, 17),10000.0,d4);

            SalesRecord sr1 = new SalesRecord(1, new DateTime(2018, 9, 25), 11000.0, SalesStatus.Billed, s1);
            SalesRecord sr2 = new SalesRecord(2, new DateTime(2019, 9, 25), 4000.0, SalesStatus.Pending, s2);
            SalesRecord sr3 = new SalesRecord(3, new DateTime(2020, 1, 21), 17000.0, SalesStatus.Billed, s3);
            SalesRecord sr4 = new SalesRecord(4, new DateTime(2015, 3, 31), 9000.0, SalesStatus.Canceled, s4);

            _context.Department.AddRange(d1, d2, d3, d4);
            _context.Seller.AddRange(s1, s2, s3, s4);
            _context.SalesRecord.AddRange(sr1, sr2, sr3, sr4);

            _context.SaveChanges();
        }
    }
}
