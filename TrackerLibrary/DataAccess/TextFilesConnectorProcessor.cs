using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;

namespace TrackerLibrary.DataAccess.TextFilesHelpers
{
    public static class TextFilesConnectorProcessor
    {
        public static string GetFullFilePath(this string fileName)
        {
            var dirPath = ConfigurationManager.AppSettings["filePath"];
            var fullFilePath = Path.Combine(dirPath, fileName);
            return fullFilePath;
        }

        public static List<string> LoadFileOrGetNewStringList(this string fullFilePath)
        {
            if (!File.Exists(fullFilePath))
            {
                return new List<string>();
            }

            return File.ReadAllLines(fullFilePath).ToList();
        }

        public static List<PrizeModel> ConvertToPrizeModel(this List<string> lines)
        {
            var prizes = new List<PrizeModel>();

            foreach (var line in lines)
            {
                string[] cols = line.Split(',');

                var currentPrize = new PrizeModel
                {
                    Id = int.Parse(cols[0]),
                    PlaceNumber = int.Parse(cols[1]),
                    PlaceName = cols[2],
                    PrizeAmount = decimal.Parse(cols[3]),
                    PrizePercentage = double.Parse(cols[4])
                };

                prizes.Add(currentPrize);
            }

            return prizes;
        }

        public static void SaveToPrizeFile(this List<PrizeModel> prizes, string fileName)
        {
            List<string> lines = new List<string>();
            foreach (var prize in prizes)
            {
                lines.Add($"{ prize.Id }, { prize.PlaceNumber }, { prize.PlaceName }, { prize.PrizeAmount }, { prize.PrizePercentage }");
            }

            File.WriteAllLines(fileName.GetFullFilePath(), lines);
        }
    }
}
