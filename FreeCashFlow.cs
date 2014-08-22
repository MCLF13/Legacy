using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Valuation
{
    public class FreeCashFlow
    {    
        //variaveis referentes ao balanco da empresa para calculo de fundamentos
        //double FCFF;
        //double EBIT;
        //double Depreciation;
        //double Capex;
        //double deltaWC;
        //double taxrate;

        //funcao que calcula o Free Cash Flow to Firm da companhia 
        public void FreeCashFlowToFirm (double EBIT, double Depreciation, double Capex, double taxrate, double deltaWC)
        {

            FCFF = EBIT - EBIT*taxrate + Depreciation - Capex - deltaWC;
        }

        //funcao que calcula o Free Cash Flow to Equity 
        public void FreeCashFlowToEquity(double netincome, double Capex, double depreciation, deltaWC, double PrincipalPayment, double NewDebtIssued)
        {
            FCFE = netincome - Capex + Depreciation - deltaWC - PrincipalPayment + NewDebtIssued;
        }
        
        
        //funcao que calcula o weighted average cost of Capital

        public void WACC(double CostofEquity, double CostofDebt, double Equity, double Debt)
        {
            WACC= CostofEquity (Equity/(Debt + Equity)) + CostofDebt (Debt/(Debt+ Equity));
        }

    }
}
