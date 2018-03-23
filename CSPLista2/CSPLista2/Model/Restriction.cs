using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSPLista2.IModel;

namespace CSPLista2.Model
{
    class Restriction : IRestriction
    {
        Restriction(List<Variable> variables,RestrictionType restriction)
        {
            consideredVariables =variables;
            restricionType = restriction;
        }
        

        List<Variable> consideredVariables;
        RestrictionType restricionType;

     

        public bool isFullfiled()
        {
            switch (restricionType)
            {
                case RestrictionType.LessThan:

                    break;
                case RestrictionType.MoreThan:
                    break;

            }
        }
    }
}

