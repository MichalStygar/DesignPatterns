using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wycieczki.Interfaces
{
    public interface IObserwator<T>
    {
        void Aktualizuj(T obserwator);
    }
}
