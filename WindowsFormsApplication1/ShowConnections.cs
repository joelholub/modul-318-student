using SwissTransport;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    class ShowConnections
    {
        public static ListViewItem[] getListViewItems(String from, String to, Transport transport)
        {
            Connections connections = new Connections();
            connections = transport.GetConnections(from, to);

            ListViewItem[] lvi = new ListViewItem[connections.ConnectionList.Count];

            int i = 0;
            foreach (var connection in connections.ConnectionList)
            {
                //ListViewItem muss zuerst initialisiert werden, da sonst eine NullPointerException geworfen wird
                lvi[i] = new ListViewItem(DateTime.Parse(connection.From.Departure).ToShortTimeString());
                lvi[i].SubItems.Add(connection.From.Station.Name);
                lvi[i].SubItems.Add(DateTime.Parse(connection.To.Arrival).ToShortTimeString());
                lvi[i].SubItems.Add(connection.To.Station.Name);
                lvi[i].SubItems.Add(connection.Duration.Substring(3, 2) + "h " + connection.Duration.Substring(6, 2) + "min ");
                i++;
            }
            return lvi;
        }
    }
}
