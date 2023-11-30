using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace NovaMoedaInvestimentos.Models.Enums
{
    public enum ETransactionType
    {
        [Description("Compra de Ações")]
        Buy = 1,

        [Description("Venda de Ações")]
        Sell = 2,

        [Description("Depósito em Conta")]
        Deposit = 3,

        [Description("Saque")]
        Withdraw = 4
    }
}
