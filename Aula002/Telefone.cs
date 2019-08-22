using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace Aula002
{
    public class Telefone
    {
        public int Numero { get; set; }

        public void Tocar()
        {
            SystemSounds.Beep.Play();
        }

    }
}
