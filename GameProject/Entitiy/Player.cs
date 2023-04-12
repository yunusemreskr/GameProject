using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameProject.NewFolder;
using GameProject.Concrete;
using GameProject.Entitiy;

namespace GameProject.Entitiy
{
    internal class Player : IEntitiy
    {
        public int Id { get; set; }
        public long TcNo { get; set; }
        public string PlayerFirstName { get; set; }
        public string PlayerLastName { get; set; }
        public DateTime DateOfBirth { get; set; }


    }
}
