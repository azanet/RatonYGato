using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RatonYGato
{
    class Controller
    {
        private frmRatAndCat frm;
        private ModelFrmElements mdlFrmElmnts;
        private ControllerEvents ctrlEvt;

        public Controller() {

            frm = new frmRatAndCat();

            //Inicializando controladores y metodos
            this.mdlFrmElmnts = new ModelFrmElements(frm);
            this.ctrlEvt = new ControllerEvents(frm,mdlFrmElmnts);

            //Lanzando FRM
            Application.EnableVisualStyles();
            Application.Run(frm);
        }//Find el constructor


    }//Fin de Controller
}
