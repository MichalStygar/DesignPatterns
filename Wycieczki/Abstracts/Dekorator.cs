using System;
using System.Collections.Generic;
using System.Text;

namespace Wycieczki.Abstracts
{
    public abstract class Dekorator : Wycieczka
    {
        public abstract override String about();
    }
}
