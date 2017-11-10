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

        public ComplexBool(string rootsName, Func<bool> boolFunc)
        {
            root = new CBTreeOperation();
            Add(root, rootsName,boolFunc);
        }
        public void Add(IComplexBoolItem parent,IComplexBoolItem child)
        {
            if(parent is  CBTreeOperation)
            {
                ((CBTreeOperation)parent).ListRights.Add(child);
            }
        }
        public void Add(IComplexBoolItem parent, string rootsName, Func<bool> boolFunc)
        {
            if (parent is CBTreeOperation)
            {
                ((CBTreeOperation)parent).ListRights.Add(new CBTreeSimple(rootsName,boolFunc));
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
        public CBTreeOperation()
        {
            ListRights = new List<IComplexBoolItem>();
            isAnd = false;
        }

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
        public override string ToString()
        {
            if (isAnd)
            {
                return "And";
            }
            else
            {
                return "Or";
            }
        }
    }
    class CBTreeSimple : IComplexBoolItem
    {
        string Name;
        Func<bool> BoolAction;
        public CBTreeSimple(string Name, Func<bool> boolFunc)
        {
            this.Name = Name;
            BoolAction = boolFunc;
        }
        public bool Calculation()
        {
            return BoolAction();
        }
        public override string ToString()
        {
            return Name;
        }
    }
    public interface IComplexBoolItem
    {
            bool Calculation();
    }

}
