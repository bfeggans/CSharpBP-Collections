using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acme.Biz
{
    public class VendorRepository
    {
        /// <summary>
        /// Retrieve one vendor.
        /// </summary>
        /// <param name="vendorId">Id of the vendor to retrieve.</param>
        public Vendor Retrieve(int vendorId)
        {
            // Create the instance of the Vendor class
            Vendor vendor = new Vendor();

            // Code that retrieves the defined customer

            // Temporary hard coded values to return 
            if (vendorId == 1)
            {
                vendor.VendorId = 1;
                vendor.CompanyName = "ABC Corp";
                vendor.Email = "abc@abc.com";
            }
            return vendor;
        }

        public List<Vendor> Retrieve()
        {
            var vendors = new List<Vendor>()
            {
              new Vendor() {VendorId=1, CompanyName="Blake's Company", Email="123@abc.com"},
              new Vendor() {VendorId=2, CompanyName="Cool Company", Email="123@abc.com"}
            };

            return vendors;
        }

        public IEnumerable<Vendor> RetrieveEnumerable()
        {
            var vendors = new List<Vendor>()
            {
              new Vendor() {VendorId=1, CompanyName="Blake's Company", Email="123@abc.com"},
              new Vendor() {VendorId=2, CompanyName="Cool Company", Email="123@abc.com"}
            };

            return vendors;
        }

        public T RetrieveValue<T>(string sql, T defaultValue)
        {
            //Ignore the SQL string for now and just return the def value
            var value = defaultValue;
            return value;
        }

        /// <summary>
        /// Save data for one vendor.
        /// </summary>
        /// <param name="vendor">Instance of the vendor to save.</param>
        /// <returns></returns>
        public bool Save(Vendor vendor)
        {
            var success = true;

            // Code that saves the vendor

            return success;
        }
    }
}
