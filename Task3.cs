using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators_reload
{
    public class City
    {
        private int citizenNum;
        private string name;

        public int CitizenNum
        {
            get { return citizenNum; }
            set { citizenNum = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public City(int citizenNum, string name)
        {
            CitizenNum = citizenNum;
            Name = name;
        }

        public static City operator +(City city, int value)
        {
            city.CitizenNum += value;
            return city;
        }

        public static City operator -(City city, int value)
        {
            city.CitizenNum -= value;
            return city;
        }

        public static bool operator ==(City city1, City city2)
        {
            return city1.CitizenNum == city2.CitizenNum;
        }

        public static bool operator !=(City city1, City city2)
        {
            return city1.CitizenNum != city2.CitizenNum;
        }

        public static bool operator <(City city1, City city2)
        {
            return city1.CitizenNum < city2.CitizenNum;
        }

        public static bool operator >(City city1, City city2)
        {
            return city1.CitizenNum > city2.CitizenNum;
        }

        public override bool Equals(object obj)
        {
            if (obj is City)
            {
                City other = (City)obj;
                return this.CitizenNum == other.CitizenNum;
            }
            else            
                return false;
            
        }

        public override int GetHashCode()
        {
            return this.CitizenNum.GetHashCode();
        }
    }
}
