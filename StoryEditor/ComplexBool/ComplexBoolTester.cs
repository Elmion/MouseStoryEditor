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
            tn.Tag = new ComplexBool("Simple", Test);
            tn.Text = "Simple";
            tv.Nodes.Add(tn);
            Console.WriteLine(((ComplexBool)tn.Tag).Calculation());
        }
        bool Test()
        {
            return true;
        }
    }
}
