using SwissTransport;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void cbTime_CheckedChanged(object sender, EventArgs e)
        {
            if (cbTime.Checked)
            {
                lblTime.Enabled = true;
                lblTime.Visible = true;
            }
            else
            {
                lblTime.Enabled = false;
                lblTime.Visible = false;
            }
            
        }

        private void startStationDropdown_TextUpdate(object sender, EventArgs e)
        {
            String stationEntered = startStationDropdown.Text;
            Object[] dropdownValues = getDropdownValues(stationEntered, "startStationDropdown");

            if (dropdownValues != null)
            {
                startStationDropdown.Items.AddRange(dropdownValues);
            }
        }

        private void endStationDropdown_TextUpdate(object sender, EventArgs e)
        {
            String stationEntered = endStationDropdown.Text;
            Object[] dropdownValues = getDropdownValues(stationEntered, "endStationDropdown");

            if (dropdownValues != null)
            {
                endStationDropdown.Items.AddRange(dropdownValues);
            }
        }

        private void stationBoardDropdown_TextUpdate(object sender, EventArgs e)
        {
            String stationEntered = stationBoardDropdown.Text;
            Object[] dropdownValues = getDropdownValues(stationEntered, "stationBoardDropdown");

            if (dropdownValues != null)
            {
                stationBoardDropdown.Items.AddRange(dropdownValues);
            }
        }

        //Auslagern!!!
        private Object[] getDropdownValues(String stationEntered, String dropdown)
        {
            if (stationEntered.Length > 3)
            {

                if (dropdown.Equals("startStationDropdown"))
                {
                    startStationDropdown.Items.Clear();
                    startStationDropdown.SelectionStart = stationEntered.Length;
                    startStationDropdown.SelectedItem = null;
                    startStationDropdown.DroppedDown = true;
                }
                else if(dropdown.Equals("endStationDropdown"))
                {
                    endStationDropdown.Items.Clear();
                    endStationDropdown.SelectionStart = stationEntered.Length;
                    endStationDropdown.SelectedItem = null;
                    endStationDropdown.DroppedDown = true;
                }
                else if (dropdown.Equals("stationBoardDropdown"))
                {
                    stationBoardDropdown.Items.Clear();
                    stationBoardDropdown.SelectionStart = stationEntered.Length;
                    stationBoardDropdown.SelectedItem = null;
                    stationBoardDropdown.DroppedDown = true;
                }
                Stations station = new Stations();
                Transport transport = new Transport();

                station = transport.GetStations(stationEntered);

                Object[] dropdownValues = new Object[station.StationList.Count];

                int i = 0;
                foreach (var currentStation in station.StationList)
                {
                    dropdownValues[i] = (currentStation.Name);
                    i++;
                }
                return dropdownValues;
            }
            return null;
        }

        private void cmdShowConnections_Click(object sender, EventArgs e)
        {
            if (!startStationDropdown.Text.Equals("") && !endStationDropdown.Text.Equals(""))
            {
                lvConnections.Items.Clear();

                Connections connections = new Connections();
                Transport transport = new Transport();
                connections = transport.GetConnections(startStationDropdown.Text, endStationDropdown.Text);


                ListViewItem[] lvi = new ListViewItem[connections.ConnectionList.Count];

                int i = 0;
                foreach (var connection in connections.ConnectionList)
                {

                    lvi[i] = new ListViewItem(DateTime.Parse(connection.From.Departure).ToShortTimeString());
                    lvi[i].SubItems.Add(connection.From.Station.Name);
                    lvi[i].SubItems.Add(DateTime.Parse(connection.To.Arrival).ToShortTimeString());
                    lvi[i].SubItems.Add(connection.To.Station.Name);
                    lvi[i].SubItems.Add(connection.Duration.Substring(3,2) +  "h " + connection.Duration.Substring(6, 2) + "min ");
                    i++;
                }
                lvConnections.Items.AddRange(lvi);
            }
        }

        private void lvConnections_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cmdStationBoard_Click(object sender, EventArgs e)
        {
            lvConnections.Items.Clear();

            Transport transport = new Transport();
            StationBoardRoot stationBoard = new StationBoardRoot();

            String idStation = transport.GetStations(stationBoardDropdown.Text).StationList.First().Id;
            stationBoard = transport.GetStationBoard(stationBoardDropdown.Text, idStation);

            ListViewItem[] lvi = new ListViewItem[stationBoard.Entries.Count];

            int i = 0;

            foreach (var entry in stationBoard.Entries)
            {
                lvi[i] = new ListViewItem(stationBoard.Station.Name);
                lvi[i].SubItems.Add(entry.Name);
                lvi[i].SubItems.Add(DateTime.Parse(entry.Stop.Departure.ToString()).ToShortTimeString());
                lvi[i].SubItems.Add(entry.To);
                i++;
            }
            lvDepartureTable.Items.AddRange(lvi);
        }

        private void btnShowStartStationMap_Click(object sender, EventArgs e)
        {
            Stations station = new Stations();
            Transport transport = new Transport();
            station = transport.GetStations(startStationDropdown.Text);
            showOnMap(station);
        }

        private void btnShowEndStationMap_Click(object sender, EventArgs e)
        {
            Stations station = new Stations();
            Transport transport = new Transport();
            station = transport.GetStations(endStationDropdown.Text);
            showOnMap(station);
        }

        private void btnShowStationBoardMap_Click(object sender, EventArgs e)
        {
            Stations station = new Stations();
            Transport transport = new Transport();
            station = transport.GetStations(stationBoardDropdown.Text);
            showOnMap(station);
        }
        private void showOnMap(Stations station)
        {
            double xCor = station.StationList.First().Coordinate.XCoordinate;
            double yCor = station.StationList.First().Coordinate.YCoordinate;
            String mapLink = "https://www.google.ch/maps/?q=" + xCor + "," + yCor + "&z=16?hl=en";
            Process.Start(mapLink);
        }

        //Disable/Enable Google Maps
        private void startStationDropdown_TextChanged(object sender, EventArgs e)
        {
            if (startStationDropdown.Text.Length > 0)
            {
                btnShowStartStationMap.Enabled = true;
                btnShowStartStationMap.Image = global::WindowsFormsApplication1.Properties.Resources.imgres;
                btnShowStartStationMap.Refresh();
            }
            else
            {
                btnShowStartStationMap.Enabled = false;
                btnShowStartStationMap.Image = global::WindowsFormsApplication1.Properties.Resources.imgres_disabled;
            }
        }

        private void endStationDropdown_TextChanged(object sender, EventArgs e)
        {
            if (endStationDropdown.Text.Length > 0)
            {
                btnShowEndStationMap.Enabled = true;
                btnShowEndStationMap.Image = global::WindowsFormsApplication1.Properties.Resources.imgres;
                btnShowEndStationMap.Refresh();
            }
            else
            {
                btnShowEndStationMap.Enabled = false;
                btnShowEndStationMap.Image = global::WindowsFormsApplication1.Properties.Resources.imgres_disabled;
            }
        }

        private void stationBoardDropdown_TextChanged(object sender, EventArgs e)
        {
            if (stationBoardDropdown.Text.Length > 0)
            {
                btnShowStationBoardMap.Enabled = true;
                btnShowStationBoardMap.Image = global::WindowsFormsApplication1.Properties.Resources.imgres;
                btnShowStationBoardMap.Refresh();
            }
            else
            {
                btnShowStationBoardMap.Enabled = false;
                btnShowStationBoardMap.Image = global::WindowsFormsApplication1.Properties.Resources.imgres_disabled;
            }
        }

        private void startStationDropdown_DropDown(object sender, EventArgs e)
        {
            startStationDropdown.Cursor = System.Windows.Forms.Cursors.Arrow;
        }

        private void endStationDropdown_DropDown(object sender, EventArgs e)
        {
            endStationDropdown.Cursor = System.Windows.Forms.Cursors.Arrow;
        }

        private void stationBoardDropdown_DropDown(object sender, EventArgs e)
        {
            stationBoardDropdown.Cursor = System.Windows.Forms.Cursors.Arrow;
        }
    }
}