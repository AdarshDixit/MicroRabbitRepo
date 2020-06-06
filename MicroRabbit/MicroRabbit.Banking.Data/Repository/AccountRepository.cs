using MicroRabbit.Banking.Data.Context;
using MicroRabbit.Banking.Domain.Interfaces;
using MicroRabbit.Banking.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbit.Banking.Data.Repository
{
    public class AccountRepository : IAccountRepository
    {
        private readonly BankingDBContext bankingDBContext;

        public AccountRepository(BankingDBContext bankingDBContext)
        {
            this.bankingDBContext = bankingDBContext;
        }
        public IEnumerable<Account> GetAccounts() 
        {
            return bankingDBContext.Accounts;
        }
    }
}
