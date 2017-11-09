using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoryEditor.ComplexBool
{
    public class ComplexBool : IComplexBoolItem
    {
        private IComplexBoolItem root;

        public ComplexBool(Func<bool> boolFunc)
        {
            root = new CBTreeOperation();
            Add(root, new CBTreeSimple(boolFunc));
        }
        public void Add(IComplexBoolItem parent,IComplexBoolItem child)
        {
            if(parent is  CBTreeOperation)
            {
                ((CBTreeOperation)parent).ListRights.Add(child);
            }
        }
        public void Add(IComplexBoolItem parent,Func<bool> boolFunc)
        {
            if (parent is CBTreeOperation)
            {
                ((CBTreeOperation)parent).ListRights.Add(new CBTreeSimple(boolFunc));
            }
        }
        public bool Calculation()
        {
           return root.Calculation();
        }
    }
    internal class CBTreeOperation : IComplexBoolItem
    {
        internal List<IComplexBoolItem> ListRights;
        bool isAnd;
        public bool Calculation()
        {
            if (ListRights.Count > 0)
            {
                bool Left = ListRights[0].Calculation();
                foreach (IComplexBoolItem Right in ListRights)
                {

                    if (isAnd)
                    {
                        Left =  Right.Calculation() && Left;
                    }
                    else
                    {
                        Left = Right.Calculation() || Left;
                    }
                }
                return Left;
            }
            return false;
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
