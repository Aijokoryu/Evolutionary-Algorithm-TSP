using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evolutionary_Algorithm_TSP {
    /// <summary>
    /// Class <c>Tsp</c> Creates a Population which represents a (not perfect) Path, for a given TSP Problem with evolutionary and generative algorithms.
    /// </summary>
    internal class Population {
        /// <value>Field <c>fitnessValue</c> Sum of all costs in the population </value>
        public float fitnessValue;
        /// <value>Field <c>individuals</c> All individuals in the population </value>
        public List<Individual> individuals;
        public Population(float cost, List<Individual> population) {
            this.fitnessValue = cost;
            this.individuals = population;
        }
        public Population() { 
            this.fitnessValue=0;
            this.individuals = new List<Individual>();
        }
        /// <summary>
        /// Methode "AddIndividual" Adds an individual to the Population.
        /// (<paramref name="vertexId"/>).
        /// </summary>
        /// <param name="vertexId"> Id of the Individual</param>
        public void AddIndividual(int vertexId) {
            individuals.Add(new Individual(vertexId, 0));
        }
        /// <summary>
        /// Methode "RecalculateFitnessValue" recalculates all costs for each individual and the overall cost.
        /// (<paramref name="paths"/>).
        /// </summary>
        /// <param name="paths"> The adjacency matrix from the TSP class</param>
        public void RecalculateFitnessValue(Dictionary<int, Dictionary<int, float>> paths) {
            if (individuals.Count < 2) return;
            float totalCost = 0;
            for (int i=0; i< individuals.Count-1; i++) {
                individuals[i].costToNextVertex = paths[individuals[i].vertex][individuals[i + 1].vertex];
                fitnessValue += individuals[i].costToNextVertex;
            }
            individuals[individuals.Count - 1].costToNextVertex = paths[individuals[individuals.Count - 1].vertex][individuals[0].vertex];
            fitnessValue += individuals[individuals.Count - 1].costToNextVertex;

        }
        public override string ToString() {
            var individualsText = "[";
            foreach(Individual individual in individuals) {
                individualsText += individual + ", ";
            }
            individualsText += "]";
            return "Cost: " + fitnessValue + "\nIndividuals:" + individualsText;
        }
    }
}
