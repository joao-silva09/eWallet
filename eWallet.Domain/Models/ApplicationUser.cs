using eWallet.Domain.Models;
using Microsoft.AspNetCore.Identity;

namespace eWallet.Infrastructure.Data
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName {  get; set; }
        public string LastName { get; set; }
        public virtual IEnumerable<Objetivo>? Objetivos { get; set; }
        public virtual IEnumerable<Conta>? Contas { get; set; }
        public virtual IEnumerable<Divida>? Dividas { get; set; }
        public virtual IEnumerable<Operacao>? Operacoes { get; set; }
    }
}
