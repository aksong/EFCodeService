using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeService.Tests
{
    [TestClass]
    public class EFCodeServiceTests
    {
        [TestMethod]
        public void Test()
        {
            EfDbContext context = new EfDbContext();
            EFCodeService svc = new EFCodeService(context, 5);
            for (int i = 0; i < 100; i++)
            {
                var mycode = svc.GenerateCode();
            }
        }
    }

    public class EfDbContext : DbContext
    {
        public DbSet<EFCode> Codes { get; set; }
    }
}
