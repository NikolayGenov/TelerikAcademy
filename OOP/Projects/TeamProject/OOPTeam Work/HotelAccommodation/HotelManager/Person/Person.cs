﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HotelManager.Person
{
    public abstract class Person : IPay
    {
        private uint id; //must be unique

        public string Name { get; set; }

        private static readonly List<uint> identifiers = new List<uint>();

        private decimal wallet;

        public decimal Wallet
        {
            get
            {
                return this.wallet;
            }
            set
            {
                if (value < 0)
                {
                    throw new PersonException("I am broke! Not enough money!");
                }
                this.wallet = value;
            }
        }

        public uint Id
        {
            get
            {
                return this.id;
            }
             set
            {
                if (identifiers.IndexOf(value) != -1)
                {
                    throw new ArgumentException("This ID is already in the list!");
                }
                identifiers.Add(value);
                this.id = value;
            }
        }

        public Person(uint id, string name, decimal wallet)
        {
            this.Id = id;
            this.Name = name;
            this.Wallet = wallet;
        }
        
        public void CollectMoney(decimal ammount)
        {
            this.Wallet += ammount;
        }

        public bool RequestMoney(decimal ammount)
        {

            return ammount <= this.Wallet;
        }
        
        public decimal PayMoney(decimal ammount)
        {
            this.Wallet -= ammount;
            return ammount;
        }

        public string Ballance()
        {
            return String.Format("{0:0.00}", this.Wallet);
        }
    }
}