using System.Collections.Generic;
using System.Data;

namespace BasicGroceryStore
{
    public class BLL
    {
        private static BLL instance;
        public static BLL Instance
        {
            get 
            {
                if (instance == null)
                    instance = new BLL();
                return instance;
            }
        }

        #region Product
        public bool createProduct(Product product)
        {
            return DAO_Product.createProduct(product);
        }

        public bool updateProduct(Product product)
        {
            return DAO_Product.updateProduct(product);
        }

        public bool deleteProduct(string id)
        {
            return DAO_Product.deleteProduct(id);
        }

        public DataTable getAllProduct()
        {
            return DAO_Product.getAllProduct();
        }

        public DataTable getAllProductOfSupplier(string supplier_id)
        {
            return DAO_Product.getAllProductOfSupplier(supplier_id);
        }

        public List<string> getAllTypeOfProduct()
        {
            return DAO_Product.getAllTypeOfProduct();
        }

        public List<string> getAllUnit()
        {
            return DAO_Product.getAllUnit();
        }

        public DataTable FindProductByName(string name)
        {
            return DAO_Product.FindProductByName(name);
        }

        public DataTable FindProductByPriceRange(float from, float to)
        {
            return DAO_Product.FindProductByPriceRange(from, to);
        }

        public DataTable FindProductBySupplier(string supplierName)
        {
            return DAO_Product.FindProductBySupplier(supplierName);
        }

        public DataTable FindProductByTypeProduct(string typeProduct)
        {
            return DAO_Product.FindProductByTypeProduct(typeProduct);
        }
        #endregion

        #region Staff
        public DataTable getAllStaff()
        {
            return DAO_Staff.getAllStaff();
        }

        public Staff getStaff(string id)
        {
            return DAO_Staff.getStaff(id);
        }

        public bool createStaff(Staff staff)
        {
            return DAO_Staff.createStaff(staff);
        }

        public bool updateStaff(Staff staff)
        {
            return DAO_Staff.updateStaff(staff);
        }

        public bool deleteStaff(string staff_id)
        {
            return DAO_Staff.deleteStaff(staff_id);
        }

        public DataTable FindStaffByAddress(string address)
        {
            return DAO_Staff.FindStaffByAddress(address);
        }

        public DataTable FindStaffByAgeRange(int from, int to)
        {
            return DAO_Staff.FindStaffByAgeRange(from, to);
        }

        public DataTable FindStaffByContractsStatus(string contractsStatus)
        {
            return DAO_Staff.FindStaffByContract(contractsStatus);
        }

        public DataTable FindStaffByGender(string gender)
        {
            return DAO_Staff.FindStaffByGender(gender);
        }

        public DataTable FindStaffByName(string name)
        {
            return DAO_Staff.FindStaffByName(name);
        }

        public DataTable FindStaffBySpells(string spells)
        {
            return DAO_Staff.FindStaffBySpells(spells);
        }

        public DataTable FindStaffByTypeWork(string type)
        {
            return DAO_Staff.FindStaffByTypeWork(type);
        }
        #endregion

        #region Account
        public bool updateAccount(Account acc)
        {
            return DAO_Account.updateAccount(acc);
        }

        public bool deleteAccount(Account acc)
        {
            return DAO_Account.deleteAccount(acc);
        }

        public Account getAccountByStaffID(string staff_id)
        {
            return DAO_Account.getAccountByStaffID(staff_id);
        }

        public string CheckLogin(string username, string password)
        {
            return DAO_Account.checkLogin(username, password);
        }

        public void SaveAccount(Account acc, bool isSave)
        {
            DAO_Account.SaveAccount(acc, isSave);
        }
        #endregion

        #region CustomerMember
        public DataTable getAllCustomerMember()
        {
            return DAO_CustomerMember.getAllCustomerMember();
        }
        public bool createCustomerMember(CustomerMember cus)
        {
            return DAO_CustomerMember.createCustomerMember(cus);
        }

        public bool updateCustomerMember(CustomerMember cus)
        {
            return DAO_CustomerMember.updateCustomerMember(cus);
        }

        public bool deleteCustomerMember(string name)
        {
            return DAO_CustomerMember.deleteCustomerMember(name);
        }
        #endregion

        #region Imported
        public DataTable getAllImported()
        {
            return DAO_Bill.getAllBill("Imported");
        }

        public bool createImported(Imported bill)
        {
            return DAO_Bill.createBill(bill, "Imported", "");
        }

        public bool updateImported(Imported bill)
        {
            return DAO_Bill.updateBill(bill, "Imported", "");
        }

        public bool deleteImported(string bill_id)
        {
            return DAO_Bill.deleteBill("Imported", bill_id);
        }

        public int getQuantityOfImported()
        {
            return DAO_Bill.getQuantityOfBill("Imported");
        }

        public float getTotalValueOfImported_Single(string id)
        {
            return DAO_Bill.getTotalValueOfBill_Single("Imported", id);
        }

        public double getTotalValueOfImported_All()
        {
            double? value = DAO_Bill.getTotalValueOfBill_All("Imported");
            if (value == null)
                return 0;
            return value.Value;
        }

        public float getTotalBuyValue_DAY()
        {
            float? value = DAO_Bill.getTotalValueOfBill_Day("Imported");
            if (value == null)
                return 0;
            return value.Value;
        }
        #endregion

        #region ImportedDetail
        public bool createImportedDetail(BillDetail item)
        {
            return DAO_BillDetails.createBillDetail(item, "Imported");
        }

        public bool updateImportedDetail(BillDetail item)
        {
            return DAO_BillDetails.updateBillDetail(item, "Imported");
        }

        public bool deleteImportedDetail(BillDetail item)
        {
            return DAO_BillDetails.deleteBillDetail(item, "Imported");
        }

        public DataTable getImportedDetails(Bill bill)
        {
            return DAO_BillDetails.getAllItem_BillDetail("Imported", bill.ID);
        }
        #endregion

        #region Ordered
        public DataTable getAllOrdered()
        {
            return DAO_Bill.getAllBill("Ordered");
        }

        public bool createOrdered(Ordered bill)
        {
            return DAO_Bill.createBill(bill, "Ordered", bill.CustomerName);
        }

        public bool updateOrdered(Ordered bill)
        {
            return DAO_Bill.updateBill(bill, "Ordered", bill.CustomerName);
        }

        public bool deleteOrdered(string bill_id)
        {
            return DAO_Bill.deleteBill("Ordered", bill_id);
        }

        public int getQuantityOfOrdered()
        {
            return DAO_Bill.getQuantityOfBill("Ordered");
        }

        public float getTotalValueOfOrdered_Single(string id)
        {
            return DAO_Bill.getTotalValueOfBill_Single("Ordered", id);
        }

        public double getTotalValueOfOrdered_All()
        {
            double? value = DAO_Bill.getTotalValueOfBill_All("Ordered");
            if (value == null)
                return 0;
            return value.Value;
        }

        public float getTotalSellValue_DAY()
        {
            float? value = DAO_Bill.getTotalValueOfBill_Day("Ordered");
            if (value == null)
                return 0;
            return value.Value;
        }
        #endregion

        #region OrderedDetail
        public bool createOrderedDetail(BillDetail item)
        {
            return DAO_BillDetails.createBillDetail(item, "Ordered");
        }

        public bool updateOrderedDetail(BillDetail item)
        {
            return DAO_BillDetails.updateBillDetail(item, "Ordered");
        }

        public bool deleteOrderedDetail(BillDetail item)
        {
            return DAO_BillDetails.deleteBillDetail(item, "Ordered");
        }

        public DataTable getOrderedDetails(Bill bill)
        {
            return DAO_BillDetails.getAllItem_BillDetail("Ordered", bill.ID);
        }
        #endregion

        #region Supplier
        public bool createSupplier(Supplier sup)
        {
            return DAO_Supplier.createSupplier(sup);
        }
        public bool updateSupplier(Supplier sup)
        {
            return DAO_Supplier.updateSupplier(sup);
        }
        public bool deleteSupplier(string sup_id)
        {
            return DAO_Supplier.deleteSupplier(sup_id);
        }

        public Supplier getSupplier(string id)
        {
            return DAO_Supplier.getSupplier(id);
        }

        public DataTable getAllSupplier()
        {
            return DAO_Supplier.getAllSupplier();
        }

        public Dictionary<string, string> getDictionarySupplier()
        {
            return DAO_Supplier.getDictionarySupplier();
        }

        public DataTable FindSupplierByAddress(string address)
        {
            return DAO_Supplier.FindSupplierByAddress(address);
        }
        public DataTable FindSupplierByName(string name)
        {
            return DAO_Supplier.FindSupplierByName(name);
        }
        public DataTable FindSupplierByTypeProduct(string type)
        {
            return DAO_Supplier.FindSupplierByTypeProduct(type);
        }
        #endregion

        #region Contract
        public bool createContract(Contracts contract)
        {
            return DAO_Contract.createContract(contract);
        }
        public bool updateContract(Contracts contract)
        {
            return DAO_Contract.updateContract(contract);
        }
        public bool deleteContract(string contract_id)
        {
            return DAO_Contract.deleteContract(contract_id);
        }
        public DataTable getAllContractOfStaff(string staff_id)
        {
            return DAO_Contract.getAllConstractOfStaff(staff_id);
        }

        public Contracts getNewestContractOfStaff(string staff_id)
        {
            return DAO_Contract.getNewestConstractOfStaff(staff_id);
        }
        #endregion
    }
}
