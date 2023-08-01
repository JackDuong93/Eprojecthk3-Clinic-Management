using ClinicManagement_hk3.Models;
using System.Security.Principal;

namespace AccountCoreMVCApp.Repositories
{
    public class AccountServices : IAccountServices
    {
        private Projecthk3Context _context;
        public AccountServices(Projecthk3Context context)
        {
            _context = context;
        }
        public Account checkLogin(string accNo, string pinCode)
        {
            Account account = _context.Accounts
                .SingleOrDefault(a => a.Email.Equals(accNo));
            if (account != null) {
                if(account.PassWord.Equals(pinCode)) {
                    return account;
                }else
                {
                    return null;
                }
            }
            else
            {
                return null;
            }
        }

        public void createAccount(Account newaccount)
        {
            Account account = _context.Accounts
                .SingleOrDefault(a => a.Email.Equals(newaccount.Email));
            if(account == null) {  //chưa có tài khoản
                _context.Accounts.Add(newaccount); //thì thêm mới
                _context.SaveChanges();//lưu xuống database
            }
        }

        public void deleteAccount(string accNo)
        {

            Account account = _context.Accounts
                .SingleOrDefault(a => a.Email.Equals(accNo));
            if (account != null)
            {  //chưa có tài khoản
                _context.Accounts.Remove(account);                
                _context.SaveChanges();//lưu xuống database
            }
        }

        public List<Account> findAll()
        {
          return _context.Accounts.ToList();
        }

        public Account findOne(string accNo)
        {
            Account account = _context.Accounts
                .SingleOrDefault(a => a.Email.Equals(accNo));
            if(account != null)
            {
                return account;
            }
            else
            {
                return null;
            }
        }

        public void updateAccount(Account editaccount)
        {
            Account account = _context.Accounts
                .SingleOrDefault(a => a.Email.Equals(editaccount.Email));
            if(account != null)
            {
                account.UserId = editaccount.UserId;
                account.FullName = editaccount.FullName;
                account.UserName = editaccount.UserName;
                account.Email = editaccount.Email;
                account.PassWord = editaccount.PassWord;
                account.Phone = editaccount.PassWord;
                account.State = editaccount.State;
                account.RoleId = editaccount.RoleId;
                _context.SaveChanges();
            }
        }
    }
}
