using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RatonYGato
{
    class ModelFrmElements{

        private frmRatAndCat frm;
        private int xCoord;
        private int yCoord;
        private Random random = new Random();


        public ModelFrmElements(frmRatAndCat frm) {
            this.frm = frm;
        }


       
        public void moveBtn(){
            this.yCoord = random.Next(frm.BtnRaton.Height, frm.Panel1.Height - frm.BtnRaton.Height - 10);
            this.xCoord = random.Next(frm.BtnRaton.Width, frm.Panel1.Width - frm.BtnRaton.Width);
            frm.BtnRaton.Location = new System.Drawing.Point(xCoord, yCoord);
        }

    }//Find e la clase ModelFrmElements
}
