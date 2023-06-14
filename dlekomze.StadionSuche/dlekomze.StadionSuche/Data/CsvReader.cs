using dlekomze.StadionSuche.Model;
using Microsoft.UI.Xaml.Shapes;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace dlekomze.StadionSuche.Data
{
    public class CsvReader
    {
        public string BasisPfad { get; }
        public CsvReader(string basisPfad = "")
        {
            BasisPfad = basisPfad;
        }

        public async Task<List<Stadion>> LadenStadien()
        {
            var stadien = new List<Stadion>();
            string dateipfad = System.IO.Path.Combine(BasisPfad, @"Stadion.csv");
            using var stream = new StreamReader(File.OpenRead(dateipfad));

            await stream.ReadLineAsync();
            while (await stream.ReadLineAsync() is string zeile)
            {
                var teile = zeile.Split(",");
                DateTime? eroeffnung = string.IsNullOrWhiteSpace(teile[5]) ? null :
                    DateTime.ParseExact(teile[5], "yyyy-mm-dd", CultureInfo.InvariantCulture);
                var stadion = new Stadion
                {
                    Id = int.Parse(teile[0]),
                    Bezeichnung = teile[1],
                    Kapazitaet = int.Parse(teile[2]),
                    Stadt = teile[3],
                    Land = teile[4],
                    Eroeffnung = eroeffnung

                };

                stadien.Add(stadion);
                await Task.Delay(500);
            }

            return stadien;
        }

    }
}
