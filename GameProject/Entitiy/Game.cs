﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameProject.NewFolder;
using GameProject.Concrete;
using GameProject.Entitiy;

namespace GameProject.Entitiy
{
    internal class Game : IEntitiy
    {
        public string GameName { get; set; }
        public int GamePrice { get; set; }

    }
}