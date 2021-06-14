using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wycieczki.Interfaces
{
    public interface IObserwowany<T>
    {
        public void Dodaj(T obserwator);
        public void Usun(T obserwator);
        public void Powiadomienie();
    }
}
