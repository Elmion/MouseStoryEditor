using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoryEditor.ComplexBool
{
    public class ComplexBool
    {
        public IComplexBoolItem root;

    }
    class CBTreeOperation : IComplexBoolItem
    {
        IComplexBoolItem Right;
        IComplexBoolItem Left;
        bool isAnd;
        public bool Calculation()
        {
                if(isAnd)
                {
                    return Right.Calculation() && Left.Calculation();
                }
                else
                {
                    return Right.Calculation() || Left.Calculation();
                }   
        }
    }
    class CBTreeSimple : IComplexBoolItem
    {
        Func<bool> BoolAction;
        public CBTreeSimple(Func<bool> boolFunc)
        {
            BoolAction = boolFunc;
        }
        public bool Calculation()
        {
            return BoolAction();
        }
    }
    public interface IComplexBoolItem
    {
            bool Calculation();
    }

}
