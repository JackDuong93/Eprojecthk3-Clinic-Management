using ClinicManagement_hk3.Models;

namespace AccountCoreMVCApp.Repositories
{
    public interface IAccountServices
    {
        Account checkLogin(string accNo, string pinCode);
        List<Account> findAll();
        Account findOne(string accNo);
        void createAccount(Account newaccount);
        void updateAccount(Account editaccount);
        void deleteAccount(string accNo);

    }
}
