using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class Viewmodel
    {
        internal void ChangeValue(int x, int y, int newmodulvalue)
        {
            string newviewvalue = "";
            if (newmodulvalue == 1)
                newviewvalue = "x";
            if (newmodulvalue == 2)
                newviewvalue = "o";
            string buttonname = "button" + x.ToString() + y.ToString();
            
            view.ChangeButtonconten(buttonname, newviewvalue);
        }
        Model model;
        MainWindow view;
        public Viewmodel(Model model, MainWindow mainWindow)
        {
            
            model.viewmodel = this;
            this.model = model;
            view = mainWindow;
        }
        public void Cor(string name)
        {
            string sub = name.Substring(6);
            int x = Convert.ToInt32(sub[0].ToString());
            int y = Convert.ToInt32(sub[1].ToString());
            
            
            model.main(x,y);

        }
        
        
        

        

    }   
}
