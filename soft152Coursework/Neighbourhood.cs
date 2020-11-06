using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace soft152Coursework
{
    class Neighbourhood
    {
        private string neighbourhoodName;
        private int neighbourhoodProperties;
        public Property[] neighbourhoodAllProperties;
        //Constructors
        //Constructor for passing in Neighbour data
        public Neighbourhood(string inNeighbourhoodName, int inNeighbourhoodProperties, Property[] inAllProperties)
        {
            neighbourhoodName = inNeighbourhoodName;
            neighbourhoodProperties = inNeighbourhoodProperties;
            neighbourhoodAllProperties = inAllProperties;
        }
        //Constructor for creating a NEW neighbourhood
        public Neighbourhood(string inNeighbourhoodName)
        {
            neighbourhoodName = inNeighbourhoodName;
            neighbourhoodProperties = 0;
            neighbourhoodAllProperties = null;
        }

        //Getters
        public string getNeighbourhoodName()
        {
            return neighbourhoodName;
        }
        public string getNeighbourhoodProperties()
        {
            return neighbourhoodProperties.ToString();
        }
        public int getIntNumProperties()
        {
            return neighbourhoodProperties;
        }
        public Property[] GetProperties()
        {
            return neighbourhoodAllProperties;
        }
        //Setters
        public void setNeighbourhoodName(string inNeighbourhoodName)
        {
            neighbourhoodName = inNeighbourhoodName;
        }
        public void setNeighbourhoodProperties(string inNeighbourhoodProperties)
        {
            neighbourhoodProperties = Convert.ToInt32(inNeighbourhoodProperties);
        }
        public void setProperties(Property[] inNeighbourhoodAllProperties)
        {
            neighbourhoodAllProperties = inNeighbourhoodAllProperties;
        }
        //Methods
        public Neighbourhood[] getAllNeighbourhoods()
        {
            return getAllNeighbourhoods();
        }

    }
}
