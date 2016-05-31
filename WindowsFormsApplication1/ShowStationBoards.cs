using SwissTransport;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    class ShowStationBoards
    {
        public static ListViewItem[] showStationBoardRoot (String station, Transport transport)
        {
            StationBoardRoot stationBoardRoot = new StationBoardRoot();

            String idStation = transport.GetStations(station).StationList.First().Id;
            stationBoardRoot = transport.GetStationBoard(station, idStation);

            ListViewItem[] lvi = new ListViewItem[stationBoardRoot.Entries.Count];

            int i = 0;

            foreach (var entry in stationBoardRoot.Entries)
            {
                lvi[i] = new ListViewItem(stationBoardRoot.Station.Name);
                lvi[i].SubItems.Add(entry.Name);
                lvi[i].SubItems.Add(DateTime.Parse(entry.Stop.Departure.ToString()).ToShortTimeString());
                lvi[i].SubItems.Add(entry.To);
                i++;
            }
            return lvi;
        }
    }
}
