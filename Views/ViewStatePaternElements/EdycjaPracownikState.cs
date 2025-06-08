﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCWinFormsMasterDetail
{
    public class EdycjaPracownikState:GrupaPracowniczaState
    {

        public EdycjaPracownikState(IGrupyPracowniczeViewMethodsToManipulateView frm) : base(frm)
        { 
        }
        
        public override void SavePracownikClick()
        {
            _frm.State = new EdycjaGrupaPracowniczaState(_frm);
        }
        public override void CancelPracownikClick()
        {
            _frm.State = new EdycjaGrupaPracowniczaState(_frm);
        }

        public override string ToString()
        {
            return "EdycjaPracownikState"; 
        }
    }
}
