using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domaines
{
    public class Passenger
    {
        public DateTime BirthDate { get; set; }
        public string EmailAddress {  get; set; }
        public string FirstName {  get; set; }
        public int Id {  get; set; }
        public string LastName { get; set; }
        public string PassportNumber { get; set; }
        public int TelNumber { get; set; }
        public ICollection<Flight> Flights { get; set; }
        public bool CheckProfile (string nom, string prenom)
        {
            return nom==LastName && prenom==FirstName;
        }
        public bool CheckProfile(string nom, string prenom, string Email)
        {
            return nom == LastName && prenom == FirstName && Email==EmailAddress;
        }
        public bool CheckProfileReplacemenet(string nom, string prenom, string Email=null)
        {
            if (Email==null)
                return nom == LastName && prenom == FirstName;
            return nom == LastName && prenom == FirstName && Email == EmailAddress;
        }
        public virtual void PassengerType ()
        {
            Console.WriteLine("I'm a passenger");
        }
    }
}
