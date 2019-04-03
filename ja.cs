using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using mojabiblioteka;

namespace projekt1
{
    class ja
    {
        public ja()
        {
            moja m = new moja();
            
        }
        private class moja
        {
            public moja()
            {
                pokaz();
            }
            private void pokaz()
            {
                autor a= new autor();
                MessageBox.Show(a.wyswietl(), "Autor programu", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
