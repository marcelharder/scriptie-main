using System.Collections.Generic;
using System.Threading.Tasks;
using api.entities;
using api.Interfaces;

namespace api.implementations
{
    public class Statistics : IStatistics
    {
        public async Task<CAS> CalculateCASBDR(string value)
        {
            var result = new CAS();
             await Task.Run(() =>
            {
                result.predicted = "1";
                result.Perc_Predicted = "5";
                result.BDR_perc_changed = "3";
                result.LLN = "2";
                result.ULN = "34";
                result.zscore = "2";
                result.predicted = "9";
                result.measured = value;

            });

            return result;
        }

        public async Task<CAS> CalculateCASERV(string value)
        {
            var result = new CAS();
             await Task.Run(() =>
            {
                result.predicted = "11";
                result.Perc_Predicted = "15";
                result.BDR_perc_changed = "13";
                result.LLN = "12";
                result.ULN = "134";
                result.zscore = "12";
                result.predicted = "19";
                      result.measured = value;


            });

            return result;
        }

        public async Task<CAS> CalculateCASFEV1(string value)
        {
            var result = new CAS();
             await Task.Run(() =>
            {
                result.predicted = "21";
                result.Perc_Predicted = "25";
                result.BDR_perc_changed = "23";
                result.LLN = "22";
                result.ULN = "234";
                result.zscore = "22";
                result.predicted = "29";      result.measured = value;


            });

            return result;
        }

        public async Task<CAS> CalculateCASIC(string value)
        {
            var result = new CAS();
             await Task.Run(() =>
            {
                result.predicted = "31";
                result.Perc_Predicted = "35";
                result.BDR_perc_changed = "33";
                result.LLN = "32";
                result.ULN = "334";
                result.zscore = "32";
                result.predicted = "39";      result.measured = value;


            });

            return result;
        }

        public async Task<CAS> CalculateCASRV(string value)
        {
            var result = new CAS();
             await Task.Run(() =>
            {
                result.predicted = "41";
                result.Perc_Predicted = "45";
                result.BDR_perc_changed = "43";
                result.LLN = "42";
                result.ULN = "434";
                result.zscore = "42";
                result.predicted = "49";      result.measured = value;


            });

            return result;
        }

        public async Task<CAS> CalculateCASTLC(string value)
        {
             var result = new CAS();
             await Task.Run(() =>
            {
                result.predicted = "51";
                result.Perc_Predicted = "55";
                result.BDR_perc_changed = "53";
                result.LLN = "52";
                result.ULN = "534";
                result.zscore = "52";
                result.predicted = "59";      result.measured = value;


            });

            return result;
        }

        public async Task<CAS> CalculateCASVC(string value)
        {
            var result = new CAS();
             await Task.Run(() =>
            {
                result.predicted = "61";
                result.Perc_Predicted = "65";
                result.BDR_perc_changed = "63";
                result.LLN = "62";
                result.ULN = "634";
                result.zscore = "62";
                result.predicted = "69";      result.measured = value;


            });

            return result;
        }

        public async Task<GLI> CalculateGLIERV(string value)
        {
             var result = new GLI();
             await Task.Run(() =>
            {
                result.predicted = "71";
                result.Perc_Predicted = "75";
                result.BDR_perc_changed = "73";
                result.LLN = "72";
                result.ULN = "734";
                result.zscore = "72";
                result.predicted = "79";      result.measured = value;


            });

            return result;
        }

        public async Task<GLI> CalculateGLIFEV1(string value)
        {
            var result = new GLI();
             await Task.Run(() =>
            {
                result.predicted = "81";
                result.Perc_Predicted = "85";
                result.BDR_perc_changed = "83";
                result.LLN = "82";
                result.ULN = "834";
                result.zscore = "82";
                result.predicted = "89";      result.measured = value;


            });

            return result;
        }

        public async Task<GLI> CalculateGLIIC(string value)
        {
             var result = new GLI();
             await Task.Run(() =>
            {
                result.predicted = "91";
                result.Perc_Predicted = "95";
                result.BDR_perc_changed = "93";
                result.LLN = "92";
                result.ULN = "934";
                result.zscore = "92";
                result.predicted = "99";      result.measured = value;


            });

            return result;
        }

        public async Task<GLI> CalculateGLIRV(string value)
        {
             var result = new GLI();
             await Task.Run(() =>
            {
                result.predicted = "101";
                result.Perc_Predicted = "105";
                result.BDR_perc_changed = "103";
                result.LLN = "102";
                result.ULN = "1034";
                result.zscore = "102";
                result.predicted = "109";      result.measured = value;


            });

            return result;
        }

        public async Task<GLI> CalculateGLITLC(string value)
        {
             var result = new GLI();
             await Task.Run(() =>
            {
                result.predicted = "111";
                result.Perc_Predicted = "115";
                result.BDR_perc_changed = "113";
                result.LLN = "112";
                result.ULN = "1134";
                result.zscore = "112";
                result.predicted = "119";      result.measured = value;


            });

            return result;
        }

        public async Task<GLI> CalculateGLIVC(string value)
        {
             var result = new GLI();
             await Task.Run(() =>
            {
                result.predicted = "121";
                result.Perc_Predicted = "125";
                result.BDR_perc_changed = "123";
                result.LLN = "122";
                result.ULN = "1234";
                result.zscore = "122";
                result.predicted = "129";      result.measured = value;


            });

            return result;
        }
    }
}