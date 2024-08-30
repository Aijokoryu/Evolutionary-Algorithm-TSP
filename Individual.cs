using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evolutionary_Algorithm_TSP {
    /// <summary>
    /// Class <c>Individual</c> Represents a single individual city from a population path.
    /// </summary>
    internal class Individual {
        /// <value>Field <c>vertex</c> Is the ID of the given Individual </value>
        public int vertex;
        /// <value>Field <c>costToNextVertex</c> Cost to the next vertex in a population </value>
        public float costToNextVertex;
        public Individual(int vertex, float costToNextVertex) {
            this.vertex = vertex;
            this.costToNextVertex = costToNextVertex;
        }
        public override string ToString() {
            return"( Vertex:"+vertex + ", CostToNext:" + costToNextVertex.ToString()+")"; 
        }
    }
}
