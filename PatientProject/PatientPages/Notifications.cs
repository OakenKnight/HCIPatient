using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientProject.PatientPages
{
    public class Notifications
    {
        public ObservableCollection<Notification> notifications
        {
            get;
            set;
        }

        public Notifications()
        {
            notifications = new ObservableCollection<Notification>();
            notifications.Add(new Notification("Pomeren pregled", "notif1", "Pregled kod doktora Nestorovica je pomeren sa 14. na 17. jun.","11.6.2020."));
            notifications.Add(new Notification("Pomeren pregled", "notif2", "Pregled kod doktora Neskovica je pomeren sa 9. na 12. jun.","7.6.2020."));
            notifications.Add(new Notification("PRIHVACEN HITAN PREGLED!", "notif3", "Prihvacen je hitan pregled za 7. jun. Bice odrzan u 10:00h u sobi 202.","6.6.2020."));
        }

        public Notifications(ObservableCollection<Notification> lista)
        {
            this.notifications = lista;
        }


    }
}
