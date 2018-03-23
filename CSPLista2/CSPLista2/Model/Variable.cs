using CSPLista2.IModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSPLista2.Model
{
    class Variable
    {
        Variable(int value,List<int> domain,List<Variable> neightbours,List<IRestriction> restrictions)
        {
            Value = value;
            Domain = domain;
            Neightbours = neightbours;
            valueRestrictions = restrictions;
        }


       private int Value { get; set; }
       private List<Variable> Neightbours { get; set; }

        public List<IRestriction> valueRestrictions;
       private List<int> Domain { get; set; }



        
        

    }
}
