using System;
using System.Windows.Forms;

namespace RatonYGato
{
    class ControllerEvents{

        private frmRatAndCat frm;
        private ModelFrmElements mdlFrmElmnts;
     

        public ControllerEvents(frmRatAndCat frm, ModelFrmElements mdlFrmElmnts) {
            this.frm = frm;
            this.mdlFrmElmnts=mdlFrmElmnts;
            initBtnsEvnts();
        }//Find el constructor


        private void initBtnsEvnts(){
            frm.BtnRaton.MouseMove += new MouseEventHandler(this.btnRaton_MouseMove);
        }

        private void btnRaton_MouseMove(object sender, MouseEventArgs e)
        {
            mdlFrmElmnts.moveBtn();
        }
    }//Fin de ControllerEvents
    }
