using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using FinanceEnterpriseApi.Classes.Finance;

namespace FinanceEnterpriseApi.Services
{
    public class ConversionFileHelpers : ControllerBase
    {
        public async Task<ActionResult<List<ObjectConvert>>> ParseObjectConversionFile(string filename)
        {
            var conversionFile = new List<ObjectConvert>();

            FileInfo conversionFileInfo = new(filename);

            using StreamReader reader = conversionFileInfo.OpenText();
            string line;

            while ((line = await reader.ReadLineAsync()) != null)
            {
                if (line.Length <= 10) continue;

                var conversionLine = new ObjectConvert
                {
                    OldObj = line[..10].Trim(),
                    NewObj = line[11..].Trim()
                };

                conversionFile.Add(conversionLine);
            }

            return conversionFile;
        }

        public async Task<ActionResult<List<KeyObjConvert>>> ParseKeyObjectConversionFile(string filename)
        {
            var conversionFile = new List<KeyObjConvert>();

            FileInfo conversionFileInfo = new(filename);

            using StreamReader reader = conversionFileInfo.OpenText();
            string line;

            while ((line = await reader.ReadLineAsync()) != null)
            {
                if (line.Length <= 10) continue;

                var conversionLine = new KeyObjConvert
                {
                    OldKey = line[..10].Trim(),
                    OldObj = line.Substring(11, 8).Trim(),
                    NewKey = line.Substring(23, 10).Trim(),
                    NewObj = line[34..].Trim()
                };

                conversionFile.Add(conversionLine);
            }

            return conversionFile;
        }
    }
}
