using SwissTransport;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Search
    {
        public static Object[] getDropdownValues(String stationEntered, System.Windows.Forms.ComboBox cmo, Transport transport)
        {
            if (stationEntered.Length > 3)
            {
                cmo.Items.Clear();
                //Verhindert das der Cursor resetet wird
                cmo.SelectionStart = stationEntered.Length;
                cmo.SelectedItem = null;
                
                
                Stations station = new Stations();

                station = transport.GetStations(stationEntered);

                Object[] dropdownValues = new Object[station.StationList.Count];

                int i = 0;
                foreach (var currentStation in station.StationList)
                {
                    dropdownValues[i] = (currentStation.Name);
                    i++;
                }
                cmo.DroppedDown = true;
                return dropdownValues;
            }
            return null;
        }
    }
}
