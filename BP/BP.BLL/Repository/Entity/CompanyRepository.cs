using BP.DAL.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BP.BLL.Repository.Entity
{
    public class CompanyRepository : Base.BaseRepository<Company>
    {
        public void CompanyUpdate(Company cy)
        {
            var dbresult = this.Find(cy.ID);
            dbresult.CompanyName = cy.CompanyName;
            dbresult.CompanyNameTitle = cy.CompanyNameTitle;
            dbresult.OutLocationID = cy.OutLocationID;
            dbresult.BranchID = cy.BranchID;
            dbresult.AccountingCode = cy.AccountingCode;
            dbresult.Mail = cy.Mail;
            dbresult.TaxAdministrationID = cy.TaxAdministrationID;
            dbresult.TaxNumber = cy.TaxNumber;
            dbresult.IsActive = cy.IsActive;
            dbresult.AuthorizedName = cy.AuthorizedName;
            dbresult.AuthorizedPhone = cy.AuthorizedPhone;
            dbresult.AuthorizedCityID = cy.AuthorizedCityID;
            dbresult.AuthorizedDistrictID = cy.AuthorizedDistrictID;
            dbresult.AuthorizedAdress = cy.AuthorizedAdress;
            dbresult.İnsuranceRate = cy.İnsuranceRate;
            dbresult.CargoPrice = cy.CargoPrice;
            dbresult.PersonelName = cy.PersonelName;
            dbresult.CustomerType = cy.CustomerType;
            dbresult.ContractStart = cy.ContractStart;
            dbresult.ContractFile = cy.ContractFile;
            this.Save();

        }
        public bool statuschange(int ID)
        {
            bool result;
            var dbResult = this.Find(ID);
            if (dbResult.IsActive == true)
            {
                dbResult.IsActive = false;
                result = false;
            }
            else
            {
                dbResult.IsActive = true;
                result = true;
            }
            this.Save();
            return result;
        }
    }
}
