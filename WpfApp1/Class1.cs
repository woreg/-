using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class Model
    {
        
        public Viewmodel viewmodel;
        bool player1 = true;
        bool player2 = false;
        int[,] matrix =
        {
               { 0,0,0,},
               { 0,0,0,},
               { 0,0,0,},

        };


        public void main(int x, int y)
        {
            int i = 0;
            int u = 0;

            for (i = 0; i<= matrix.GetUpperBound(0); i++)
            {
                for (u = 0; u <= matrix.GetUpperBound(1); u++)
                {
                    
                }
            }

            
            
            if (matrix[x, y] != 0)
                return;




            //не меняем х на у;
            // определяем победителя
            // поменяем 0 на у

            int newvalue = WhoGo();
            ChangePlayer();
            matrix[x, y] = newvalue;
            viewmodel.ChangeValue(x, y, newvalue);

        }
        int WhoGo()
        {
            if (player1)
                return 1;
            if (player2)
                return 2;
            throw new Exception("неизвестный ход");
        }
        void ChangePlayer()
        {
            player1 = !player1;
            player2 = !player2;
           
        }
        public void WhoWin()
        {
           
        }


    }


        
}   
