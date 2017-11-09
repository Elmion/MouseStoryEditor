using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestEntity
{
    interface IQuestBlock
    {
        void     Check();
        string   CardDiscription { get;}
        string[] Variants { get; }
        bool     SetAnswert(byte answer);
    }
}
