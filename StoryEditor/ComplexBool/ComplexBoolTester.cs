using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoryEditor.ComplexBool
{
    public partial class ComplexBoolTester : Form
    {

        public ComplexBoolTester()
        {
            InitializeComponent();
            TreeNode tn = new TreeNode();
            tn.Tag = new ComplexBool("Simple", TestTrue);
            tn.Text = "Simple";
            tv.Nodes.Add(tn);
            Console.WriteLine(((ComplexBool)tn.Tag).Calculation());
        }
        bool TestTrue()
        {
            return true;
        }
        bool TestFalse()
        {
            return false;
        }
        private void CmAddOr_Click(object sender, EventArgs e)
        {
            InsertLogic(false);
        }

        private void AddAnd_Click(object sender, EventArgs e)
        {
            InsertLogic(true);
        }
        private void InsertLogic(bool isAnd)
        {
            if (tv.SelectedNode == null) return;
            TreeNode Parent = tv.SelectedNode.Parent;
            TreeNode Selected = tv.SelectedNode;

            CBTreeOperation NewOperation= new CBTreeOperation();
            NewOperation.isAnd = isAnd;
            TreeNode NewNode = new TreeNode();
            NewNode.Text = isAnd ? "And" : "Or";
            NewNode.Tag = NewOperation;
            if (Parent != null)
            {
                if (Parent.Tag is CBTreeOperation)
                {
                    ((CBTreeOperation)Parent.Tag).ListRights.Remove((IComplexBoolItem)Selected.Tag);
                    ((CBTreeOperation)Parent.Tag).ListRights.Add(NewOperation);
                }
                Parent.Nodes.Remove(Selected);
                Parent.Nodes.Add(NewNode);
            }
            else
            {
                tv.Nodes.Remove(Selected);
                tv.Nodes.Add(NewNode);
            }
            NewOperation.ListRights.Add((IComplexBoolItem)Selected.Tag);
            NewNode.Nodes.Add(Selected);
        }
        private void AddTrue_Click(object sender, EventArgs e)
        {
            InsertFunction(true);
        }
        private void AddFalse_Click(object sender, EventArgs e)
        {
            InsertFunction(false);
        }
        private void InsertFunction(bool TestFunc)
        {
            if (tv.SelectedNode == null) return;
            if (!(tv.SelectedNode.Tag is CBTreeOperation)) return;
            TreeNode Selected = tv.SelectedNode;

            Func<bool> func;
            if (TestFunc) func = TestTrue; else func = TestFalse; 
            CBTreeSimple NewFunction = new CBTreeSimple(TestFunc?"True":"False", func);
            ((CBTreeOperation)Selected.Tag).ListRights.Add(NewFunction);
            TreeNode NewNode = new TreeNode
            {
                Text = TestFunc ? "True" : "False",
                Tag = NewFunction
            };
            Selected.Nodes.Add(NewNode);
        }

        private void DeleteBranch_Click(object sender, EventArgs e)
        {
            if (tv.SelectedNode == null) return;
            TreeNode Parent = tv.SelectedNode.Parent;
            TreeNode Selected = tv.SelectedNode;

            if (Parent != null)
            {
                ((CBTreeOperation)Parent.Tag).ListRights.Remove((IComplexBoolItem)Selected.Tag);
                Parent.Nodes.Remove(Selected);
            }
        }

        private void bReCalc_Click(object sender, EventArgs e)
        {
            Console.WriteLine(((IComplexBoolItem)tv.Nodes[0].Tag).Calculation());
        }
    }
}
