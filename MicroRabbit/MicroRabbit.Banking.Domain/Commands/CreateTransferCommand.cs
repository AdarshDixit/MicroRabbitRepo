using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbit.Banking.Domain.Commands
{
    public class CreateTransferCommand : TransferCommand
    {
        private readonly int from;
        private readonly int to;
        private readonly decimal amount;

        public CreateTransferCommand(int from, int to, decimal amount)
        {
            this.from = from;
            this.to = to;
            this.amount = amount;
        }
    }
}
