using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StoryEditor.ComplexBool;

namespace QuestEntity
{
    class SimpleCard
    {
        public string Description { get; set; }
        public  List<Answer> ListAnswers { get;}
        public  SimpleCard()
        {
            ListAnswers = new List<Answer>();
        }
        public bool canStart()
        {
            bool Ok = false;
            foreach (var item in ListAnswers)
            {
                Ok = item.canStart() || Ok;
            }
            return Ok;
        }
        public SimpleCard TakeAnswer(sbyte a)
        {
            return ListAnswers[a].NextCard;
        }
        public List<string>  GetAnswersVariant()
        {
            List<string> OUT = new List<string>();
            if(ListAnswers.Count >= 2)
            {
                for (int i = 0; i < ListAnswers.Count; i++)
                {
                    if(ListAnswers[i].Condition.Calculation())
                    {
                        OUT.Add(ListAnswers[i].Text);
                        if (OUT.Count >= 2) break;
                    }

                }
                return OUT;
            }
            return null;
        }
    }
    class Answer
    {
        public string Text { get; set; }
        public SimpleCard NextCard { get; set; }
        public ComplexBool Condition { get; set; }

        public Answer()
        {
            Condition = new ComplexBool("Simple", () => {return true;});
        }

        public bool canStart()
        {
            return Condition.Calculation();
        }
    }
}
