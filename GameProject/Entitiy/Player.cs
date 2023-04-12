using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Entitiy
{
    internal class Player : IEntitiy
    {
        public int Id { get; set; }
        public string TcNo { get; set; }
        public string PlayerFirstName { get; set; }
        public string PlayerLastName { get; set; }
        public int BirthDate { get; set; }


    }
}
