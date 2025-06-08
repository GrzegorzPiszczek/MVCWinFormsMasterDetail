﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCWinFormsMasterDetail
{
    public class PrzegladanieGrupaPracowniczaState:GrupaPracowniczaState
    {
        public PrzegladanieGrupaPracowniczaState(IGrupyPracowniczeViewMethodsToManipulateView frm) :base(frm)
        {
             
        }

        public override void AddGrupaPracowniczaClick()
        {
            _frm.State = new EdycjaGrupaPracowniczaState(_frm);
        }
        public override void EditGrupaPracowniczaClick()
        {
            _frm.State = new EdycjaGrupaPracowniczaState(_frm);
        }

        public override string ToString()
        {
            return "PrzegladanieGrupaPracowniczaState";
        }
    }
}
