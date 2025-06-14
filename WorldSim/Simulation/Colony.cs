﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace WorldSim.Simulation
{
    public class Colony
    {
        public int Id { get; }
        public (int x, int y) Origin;
        public Color Color { get; set; } 

        public Dictionary<Resource, int> Stock = new()
        {
            [Resource.Wood] = 0,
            [Resource.Stone] = 0,
            [Resource.Food] = 0
        };
        public int HouseCount = 0;
        float _age;

        public Colony(int id, (int, int) startPos)
        {
            Id = id;
            Origin = startPos;
        }

        public void Update(float dt)
        {
            _age += dt;
            // later tech tree, population cap, etc.
        }
    }
}
