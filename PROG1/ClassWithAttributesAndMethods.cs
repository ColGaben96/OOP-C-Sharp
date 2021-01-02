using System;
using System.Collections.Generic;
using System.Text;

/// <summary>
/// Author: Gabriel Blanco
/// </summary>
namespace PROG1
{
    class ClassWithAttributesAndMethods
    {
        private string name, IDNumber, address;
        private int age;

        /// <summary>
        /// Author: Gabriel Blanco
        /// Description: Constructor Method
        /// </summary>
        /// <param name="name"></param>
        /// <param name="IDNumber"></param>
        /// <param name="address"></param>
        /// <param name="age"></param>
        public ClassWithAttributesAndMethods(string name, string IDNumber, string address, int age)
        {
            this.name = name;
            this.IDNumber = IDNumber;
            this.address = address;
            this.age = age;
        }

        public string GetName()
        {
            return name;
        }

        public void SetName(string value)
        {
            name = value;
        }

        public string GetIDNumber()
        {
            return IDNumber;
        }

        public void SetIDNumber(string value)
        {
            IDNumber = value;
        }

        public string GetAddress()
        {
            return address;
        }

        public void SetAddress(string value)
        {
            address = value;
        }

        public int GetAge()
        {
            return age;
        }

        public void SetAge(int value)
        {
            age = value;
        }
    }
}
