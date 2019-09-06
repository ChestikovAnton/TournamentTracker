using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;
using TrackerLibrary.DataAccess.TextFilesHelpers;

namespace TrackerLibrary.DataAccess
{
    public class TextFilesConnector : IDataConnection
    {
        private const string PrizesFileName = "PrizeModel.csv";

        public PrizeModel CreatePrize(PrizeModel model)
        {
            List<PrizeModel> prizes = PrizesFileName.GetFullFilePath().LoadFileOrGetNewStringList().ConvertToPrizeModel();

            int currentId = 1;

            if (prizes.Count > 0)
            {
                currentId = prizes.OrderByDescending(x => x.Id).First().Id + 1;
            }
            
            model.Id = currentId;

            prizes.Add(model);

            prizes.SaveToPrizeFile(PrizesFileName);

            return model;
        }
    }
}
