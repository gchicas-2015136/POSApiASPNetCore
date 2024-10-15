using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Infrastructure.Persistences.Interfases
{
    public interface IUnitOfWork : IDisposable
    {
        // Declaración o matricula de nuestras interfaces a nivel del repositorio

        ICategoryRepository Category { get; }
        IUserRepository User { get; }
        void SaveChanges();
        Task SaveChangesAsync();

    }
}
