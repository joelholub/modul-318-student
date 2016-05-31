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
        Transport transport = new Transport();

        public Form1()
        {
            InitializeComponent();
        }

        private void startStationDropdown_TextUpdate(object sender, EventArgs e)
        {
            Object[] dropdownValues = Search.getDropdownValues(startStationDropdown.Text, startStationDropdown, transport);

            if (dropdownValues != null)
            {
                startStationDropdown.Items.AddRange(dropdownValues);
            }
        }

        private void endStationDropdown_TextUpdate(object sender, EventArgs e)
        {
            Object[] dropdownValues = Search.getDropdownValues(endStationDropdown.Text, endStationDropdown, transport);

            if (dropdownValues != null)
            {
                endStationDropdown.Items.AddRange(dropdownValues);
            }
        }

        private void stationBoardDropdown_TextUpdate(object sender, EventArgs e)
        {
            Object[] dropdownValues = Search.getDropdownValues(stationBoardDropdown.Text, stationBoardDropdown, transport);

            if (dropdownValues != null)
            {
                stationBoardDropdown.Items.AddRange(dropdownValues);
            }
        }

        private void cmdShowConnections_Click(object sender, EventArgs e)
        {
            if (!startStationDropdown.Text.Equals("") && !endStationDropdown.Text.Equals(""))
            {
                lvConnections.Items.Clear();
                lvConnections.Items.AddRange(ShowConnections.getListViewItems(startStationDropdown.Text, endStationDropdown.Text, transport));
            }
        }

        private void cmdStationBoard_Click(object sender, EventArgs e)
        {
            lvDepartureTable.Items.Clear();
            lvDepartureTable.Items.AddRange(ShowStationBoards.showStationBoardRoot(stationBoardDropdown.Text, transport));
        }

        private void btnShowStartStationMap_Click(object sender, EventArgs e)
        {
            Stations station = new Stations();
            station = transport.GetStations(startStationDropdown.Text);
            showOnMap(station);
        }

        private void btnShowEndStationMap_Click(object sender, EventArgs e)
        {
            Stations station = new Stations();
            station = transport.GetStations(endStationDropdown.Text);
            showOnMap(station);
        }

        private void btnShowStationBoardMap_Click(object sender, EventArgs e)
        {
            Stations station = new Stations();
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