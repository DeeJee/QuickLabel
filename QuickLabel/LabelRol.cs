using QuickLabel.Entities;
using QuickLabel.Printing;
using System.Collections.Generic;

namespace QuickLabel
{
    public class LabelRol
    {
        public List<QLabel> Labels { get; set; }
        
        public LabelRol()
        {
            Labels = new List<QLabel>();
        }

        public  void AddLabel(QuickLabelData label)
        {
            QLabel newLabel=new QLabel(label);
            Labels.Add(newLabel);
        }

        public void AddLabel(QLabel label)
        {
            Labels.Add(label);
        }
    }
}
