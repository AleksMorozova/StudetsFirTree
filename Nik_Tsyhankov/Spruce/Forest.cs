using System.Collections.Generic;

namespace Spruce
{
    public class Forest
    {
        private List<Plant> _trees;
        public List<Plant> Trees
        {
            get;
            private set;
        }

        public Forest()
        {
            Trees = new List<Plant>();
        }
    }
}
