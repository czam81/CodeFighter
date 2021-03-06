﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeFighter.Models
{
    public class CodeFighterPlayer
    {
        public string name
        {
            get; set;
        }
        public string role
        {
            get; set;
        }
        public int energy
        {
            get; set;
        }
        public int life
        {
            get; set;
        }
        private int maxLife;
        private int maxEnergy = 100;
        private int healDamage = 50;
        public CodeFighterPlayer(string _name, string _role)
        {
            name = _name;
            role = _role;
        }

        public void resetLifeForRound(int _maxLife = 200, int _maxEnergy = 100)
        {
            life = _maxLife;
            energy = 0;
            maxLife = _maxLife;
            maxEnergy = _maxEnergy;
        }

        public void receivePunch()
        {
            receiveDamage(10);
        }
        public void receiveKick()
        {
            receiveDamage(20);
        }
        public void receiveSpecial()
        {
            receiveDamage(30);
        }

        public void punch()
        {
            receiveEnergy(10);
        }
        public void kick()
        {
            receiveEnergy(16);
        }
        public void special()
        {
            if (IsValidSpecial())
            {
                loseEnergy(maxEnergy);
                receiveEnergy(30);
            }
        }

        public bool IsValidSpecial() {
            return energy == maxEnergy;
        }

        public void heal()
        {
            if (energy == maxEnergy)
            {
                life = life + healDamage >= maxLife ? maxLife : life + healDamage;
                loseEnergy(maxEnergy);
            }
        }

        private void receiveDamage(int damage)
        {
            life = life - damage <= 0 ? 0 : life - damage;
        }
        private void receiveEnergy(int energyAdded)
        {
            energy = energy + energyAdded >= maxEnergy ? maxEnergy : energy + energyAdded;
        }
        private void loseEnergy(int energySpent)
        {
            energy = energy - energySpent <= 0 ? 0 : energy - energySpent;
        }
    }
}