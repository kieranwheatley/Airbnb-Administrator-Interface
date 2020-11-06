using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace soft152Coursework
{
    class District
    {
        private string districtName;
        private int districtNeighbourhoods;
        public Neighbourhood[] districtAllNeighbourhoods;

        //Constructors
        //Constructor for passing in Districts data
        public District(string inDistrictName, int inDistrictNeighbourhoods, Neighbourhood[] inAllNeighbourhoods)
        {
            districtName = inDistrictName;
            districtNeighbourhoods = inDistrictNeighbourhoods;
            districtAllNeighbourhoods = inAllNeighbourhoods;
        }
        public District(string inDistrictName)
        {
            districtName = inDistrictName;
            districtNeighbourhoods = 0;
            districtAllNeighbourhoods = null;
        }
        //Getters
        public string getDistrictName()
        {
            return districtName;
        }
        public string getDistrictProperties()
        {
            return districtNeighbourhoods.ToString();
        }
        public Neighbourhood[] GetNeighbourhoods()
        {
            return districtAllNeighbourhoods;
        }
        public int getIntNumNeighbourhoods()
        {
            return districtNeighbourhoods;
        }
        //Setters
        public void setDistrictName(string inDistrictName)
        {
            districtName = inDistrictName;
        }
        public void setDistrictNeighbourhoods(string inDistrictNeighbourhoods)
        {
            districtNeighbourhoods = Convert.ToInt32(inDistrictNeighbourhoods);
        }
        //Methods
        public Neighbourhood[] getAllNeighbourhoods()
        {
            return districtAllNeighbourhoods;
        }
    }
}
