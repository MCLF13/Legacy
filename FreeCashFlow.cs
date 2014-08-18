using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FreeCashFlow
{
    public class FreeCashFlow
    {    
        //variaveis referentes ao balanco da empresa para calculo de fundamentos
        double FCFF;
        double EBIT;
        double Depreciation;
        double Capex;
        double deltaWC;
        double taxrate;

        //funcao que calcula o Free Cash Flow to Firm da companhia 
        public void FreeCashFlowToFirm (double EBIT, double Depreciation, double Capex, double taxrate, double deltaWC)
        {

            FCFF = EBIT - EBIT*taxrate + Depreciation - Capex - deltaWC;
        }
             
    }
}
