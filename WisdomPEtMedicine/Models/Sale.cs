using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WisdomPEtMedicine.Models
{
    public record Sale(int ClientId,
        int ProductId,
        string ProductName,
        decimal ProductPrice,
        int Quantity, decimal Amount);


}
