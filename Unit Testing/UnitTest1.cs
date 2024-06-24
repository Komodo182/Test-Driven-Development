using Test_Driven_Development;

namespace Unit_Testing
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }
        #region testing getProduct
        [Test]
        public void TestGetProduct1()
        {
            using StringWriter sw = new StringWriter();
            Console.SetOut(sw);
            Program.GetProduct(1);
            var result = sw.ToString().Trim();
            Assert.That(result == "Chais");
        }
        [Test]
        public void TestGetProduct2()
        {
            using StringWriter sw = new StringWriter();
            Console.SetOut(sw);
            Program.GetProduct(0);
            var result = sw.ToString().Trim();
            Assert.That(result == "no product found with id 0");
        }
        #endregion
        #region testing getSupplier
        [Test]
        public void TestGetSupplier1()
        {
            using StringWriter sw = new StringWriter();
            Console.SetOut(sw);
            Program.GetSupplier(16);
            var result = sw.ToString().Trim();
            Assert.That(result == "Bigfoot Breweries");
        }
        [Test]
        public void TestGetSupplier2()
        {
            using StringWriter sw = new StringWriter();
            Console.SetOut(sw);
            Program.GetSupplier(0);
            var result = sw.ToString().Trim();
            Assert.That(result == "no supplier found with id 0");
        }
        #endregion
        #region testing getCustomerName
        [Test]
        public void TestGetCustomerName1()
        {
            using StringWriter sw = new StringWriter();
            Console.SetOut(sw);
            Program.GetCustomerName(0);
            var result = sw.ToString().Trim();
            Assert.That(result == "Customer with ID 0 not found");
        }
        [Test]
        public void TestGetCustomerName2()
        {
            using StringWriter sw = new StringWriter();
            Console.SetOut(sw);
            Program.GetCustomerName(1);
            var result = sw.ToString().Trim();
            Assert.That(result == "Alfreds Futterkiste");
        }
        [Test]
        public void TestGetCustomerName3()
        {
            using StringWriter sw = new StringWriter();
            Console.SetOut(sw);
            Program.GetCustomerName(39);
            var result = sw.ToString().Trim();
            Assert.That(result == "Königlich Essen");
        }
        [Test]
        public void TestGetCustomerName4()
        {
            using StringWriter sw = new StringWriter();
            Console.SetOut(sw);
            Program.GetCustomerName(77);
            var result = sw.ToString().Trim();
            Assert.That(result == "The Big Cheese");
        }
        #endregion
        #region testing getContactName
        [Test]
        public void TestGetContactName1()
        {
            using StringWriter sw = new StringWriter();
            Console.SetOut(sw);
            Program.GetContactName(0);
            var result = sw.ToString().Trim();
            Assert.That(result == "Contact for customer with ID 0 not found");
        }
        [Test]
        public void TestGetContactName2()
        {
            using StringWriter sw = new StringWriter();
            Console.SetOut(sw);
            Program.GetContactName(1);
            var result = sw.ToString().Trim();
            Assert.That(result == "M.A.");
        }
        [Test]
        public void TestGetContactName3()
        {
            using StringWriter sw = new StringWriter();
            Console.SetOut(sw);
            Program.GetContactName(39);
            var result = sw.ToString().Trim();
            Assert.That(result == "P.C.");
        }
        [Test]
        public void TestGetContactName4()
        {
            using StringWriter sw = new StringWriter();
            Console.SetOut(sw);
            Program.GetContactName(77);
            var result = sw.ToString().Trim();
            Assert.That(result == "L.N.");
        }
        #endregion
        #region testing getFullCustomerAddress
        [Test]
        public void TestGetFullCustomerAddress1()
        {
            using StringWriter sw = new StringWriter();
            Console.SetOut(sw);
            Program.GetFullCustomerAddress(0);
            var result = sw.ToString().Trim();
            Assert.That(result == "Address for customer with ID 0 not found");
        }
        [Test]
        public void TestGetFullCustomerAddress2()
        {
            using StringWriter sw = new StringWriter();
            Console.SetOut(sw);
            Program.GetFullCustomerAddress(1);
            var result = sw.ToString().Trim();
            Assert.That(result == "Obere Str. 57, Berlin, 12209, Germany");
        }
        [Test]
        public void TestGetFullCustomerAddress3()
        {
            using StringWriter sw = new StringWriter();
            Console.SetOut(sw);
            Program.GetFullCustomerAddress(39);
            var result = sw.ToString().Trim();
            Assert.That(result == "Maubelstr. 90, Brandenburg, 14776, Germany");
        }
        [Test]
        public void TestGetFullCustomerAddress4()
        {
            using StringWriter sw = new StringWriter();
            Console.SetOut(sw);
            Program.GetFullCustomerAddress(77);
            var result = sw.ToString().Trim();
            Assert.That(result == "89 Jefferson Way Suite 2, Portland, 97201, USA");
        }
        #endregion
        #region testing GetCategoryOfProduct
        [Test]
        public void TestGetCategoryOfProduct1()
        {
            using StringWriter sw = new StringWriter();
            Console.SetOut(sw);
            Program.GetCategoryOfProduct(0);
            var result = sw.ToString().Trim();
            Assert.That(result == "Category for product with ID 0 not found");
        }
        [Test]
        public void TestGetCategoryOfProduct2()
        {
            using StringWriter sw = new StringWriter();
            Console.SetOut(sw);
            Program.GetCategoryOfProduct(1);
            var result = sw.ToString().Trim();
            Assert.That(result == "Beverages");
        }
        [Test]
        public void TestGetCategoryOfProduct3()
        {
            using StringWriter sw = new StringWriter();
            Console.SetOut(sw);
            Program.GetCategoryOfProduct(7);
            var result = sw.ToString().Trim();
            Assert.That(result == "Produce");
        }
        [Test]
        public void TestGetCategoryOfProduct4()
        {
            using StringWriter sw = new StringWriter();
            Console.SetOut(sw);
            Program.GetCategoryOfProduct(12);
            var result = sw.ToString().Trim();
            Assert.That(result == "Dairy Products");
        }
        #endregion
        #region testing GetSupplierOfProduct
        [Test]
        public void TestGetsupplierOfProduct1()
        {
            using StringWriter sw = new StringWriter();
            Console.SetOut(sw);
            Program.GetSupplierOfProduct(0);
            var result = sw.ToString().Trim();
            Assert.That(result == "Supplier for product with ID 0 not found");
        }
        [Test]
        public void TestGetsupplierOfProduct2()
        {
            using StringWriter sw = new StringWriter();
            Console.SetOut(sw);
            Program.GetSupplierOfProduct(1);
            var result = sw.ToString().Trim();
            Assert.That(result == "Exotic Liquid");
        }
        [Test]
        public void TestGetsupplierOfProduct3()
        {
            using StringWriter sw = new StringWriter();
            Console.SetOut(sw);
            Program.GetSupplierOfProduct(7);
            var result = sw.ToString().Trim();
            Assert.That(result == "Grandma Kelly's Homestead");
        }
        [Test]
        public void TestGetsupplierOfProduct4()
        {
            using StringWriter sw = new StringWriter();
            Console.SetOut(sw);
            Program.GetSupplierOfProduct(12);
            var result = sw.ToString().Trim();
            Assert.That(result == "Cooperativa de Quesos 'Las Cabras'");
        }
        #endregion
    }   

}