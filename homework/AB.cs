using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework
{
    class AB
    {
    }

    public struct Loo  //loan
    {
        public double loanM;    //一般欄位
        public double yearM;
        public double RateM;
        public double dnpayM;

    }


    public struct Score  //成績單簡易版
    {
        public string studentName;    //一般欄位
        public decimal scoreChi;
        public decimal scoreEng;
        public decimal scoreMat;

    }

    public struct score
    {
        public string studentname;    //一般欄位
        public int scorechi;
        public decimal scoreeng;
        public decimal scoremat;
        public decimal scoreto;
        public decimal scoreav;

    }


    public abstract class cal
    {
        public double x { get; set; }
        public double y { get; set; }
        public abstract double answer();
    }

    public class caladd : cal 
    {
        public override double answer()
        {
            //throw new NotImplementedException();
            return x + y;
        }
    }

    public class calred : cal
    {
        public override double answer()
        {
            //throw new NotImplementedException();
            return x - y;
        }
    }

    public class calmul : cal
    {
        public override double answer()
        {
            //throw new NotImplementedException();
            return x * y;
        }
    }

    public class caldiv : cal
    {
        public override double answer()
        {
            //throw new NotImplementedException();
            return x / y;
        }
    }
}
