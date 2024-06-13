// BLL/BloodBankService.cs
using BloodBank.DAL;
using System.Data;

namespace BloodBank.BLL
{
    public class BloodBankService
    {
        private readonly DatabaseHelper _dbHelper;

        public BloodBankService()
        {
            _dbHelper = new DatabaseHelper();
        }

        public DataSet GetData(string query)
        {
            return _dbHelper.ExecuteQuery(query);
        }

        public void SetData(string query)
        {
            _dbHelper.ExecuteNonQuery(query);
        }

        public bool ValidateUser(string username, string password)
        {
            return _dbHelper.ValidateUser(username, password);
        }
    }
}
