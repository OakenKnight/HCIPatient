using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientProject.PatientPages
{
    public class ExpandersItemsList
    {
        public ObservableCollection<ExpandersItem> lista;

        public ExpandersItemsList()
        {

        }

        public ExpandersItemsList(ObservableCollection<ExpandersItem> lista)
        {
            this.lista = lista;
        }
    }
}
