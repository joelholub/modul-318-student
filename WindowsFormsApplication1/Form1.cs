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
        const String msgError = "Es ist ein Fehler aufgetreten: ";

        public Form1()
        {
            InitializeComponent();
        }

        private void startStationDropdown_TextUpdate(object sender, EventArgs e)
        {
            try
            {
                enableConnectionButton();
                Object[] dropdownValues = Search.getDropdownValues(startStationDropdown.Text, startStationDropdown, transport);

                // Werte nur ins Dropdown schreiben wenn nicht Null
                if (dropdownValues != null)
                {
                    startStationDropdown.Items.AddRange(dropdownValues);
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(msgError + exc.Message);
            }


        }

        private void endStationDropdown_TextUpdate(object sender, EventArgs e)
        {
            try
            {
                enableConnectionButton();
                Object[] dropdownValues = Search.getDropdownValues(endStationDropdown.Text, endStationDropdown, transport);

                // Werte nur ins Dropdown schreiben wenn nicht Null
                if (dropdownValues != null)
                {
                    endStationDropdown.Items.AddRange(dropdownValues);
                }
            }
            catch(Exception exc)
            {
                MessageBox.Show(msgError + exc.Message);
            }
            
        }

        private void stationBoardDropdown_TextUpdate(object sender, EventArgs e)
        {
            //Stationboard Button Disabled wenn keine Station angegeben
            if (stationBoardDropdown.Text.Length > 0)
            {
                cmdStationBoard.Enabled = true;
            }
            else
            {
                cmdStationBoard.Enabled = false;
            }

            try
            {
                Object[] dropdownValues = Search.getDropdownValues(stationBoardDropdown.Text, stationBoardDropdown, transport);

                // Werte nur ins Dropdown schreiben wenn nicht Null
                if (dropdownValues != null)
                {
                    stationBoardDropdown.Items.AddRange(dropdownValues);
                }
            }
            catch(Exception exc)
            {
                MessageBox.Show(msgError + exc.Message);
            }
            
        }

        private void cmdShowConnections_Click(object sender, EventArgs e)
        {
            //ListView neu Initialisieren
            lvConnections.Items.Clear();
            //ListView füllen
            try
            {
                lvConnections.Items.AddRange(ShowConnections.getListViewItems(startStationDropdown.Text, endStationDropdown.Text, transport));
            }
            catch(Exception exc)
            {
                MessageBox.Show(msgError + exc.Message);
            }
            
        }

        private void cmdStationBoard_Click(object sender, EventArgs e)
        {
            //ListView neu Initialisieren
            lvDepartureTable.Items.Clear();
            //ListView füllen
            try
            {
                lvDepartureTable.Items.AddRange(ShowStationBoards.showStationBoardRoot(stationBoardDropdown.Text, transport));
            }
            catch(Exception exc)
            {
                MessageBox.Show(msgError + exc.Message);
            }
            
        }

        private void btnShowStartStationMap_Click(object sender, EventArgs e)
        {
            Stations station = new Stations();
            station = transport.GetStations(startStationDropdown.Text);
            //Station auf Google Maps anzeigen
            showOnMap(station);
        }

        private void btnShowEndStationMap_Click(object sender, EventArgs e)
        {
            Stations station = new Stations();
            station = transport.GetStations(endStationDropdown.Text);
            //Station auf Google Maps Anzeigen
            showOnMap(station);
        }

        private void btnShowStationBoardMap_Click(object sender, EventArgs e)
        {
            Stations station = new Stations();
            station = transport.GetStations(stationBoardDropdown.Text);
            //Station auf Google Maps anzeigen
            showOnMap(station);
        }
        private void showOnMap(Stations station)
        {
            //Koordinaten herauslesen
            double xCor = station.StationList.First().Coordinate.XCoordinate;
            double yCor = station.StationList.First().Coordinate.YCoordinate;
            //Link erstellen für Google Maps
            String mapLink = "https://www.google.ch/maps/?q=" + xCor + "," + yCor + "&z=16?hl=en";
            //Neues Fenster mit Link öffnen
            Process.Start(mapLink);
        }

        //Disable/Enable Google Maps
        private void startStationDropdown_TextChanged(object sender, EventArgs e)
        {
            if (startStationDropdown.Text.Length > 0)
            {
                btnShowStartStationMap.Enabled = true;
                //Image ändern
                btnShowStartStationMap.Image = global::WindowsFormsApplication1.Properties.Resources.imgres;
                btnShowStartStationMap.Refresh();
            }
            else
            {
                btnShowStartStationMap.Enabled = false;
                //Image änderns
                btnShowStartStationMap.Image = global::WindowsFormsApplication1.Properties.Resources.imgres_disabled;
            }
        }

        private void endStationDropdown_TextChanged(object sender, EventArgs e)
        {
            if (endStationDropdown.Text.Length > 0)
            {
                btnShowEndStationMap.Enabled = true;
                //Image ändern
                btnShowEndStationMap.Image = global::WindowsFormsApplication1.Properties.Resources.imgres;
                btnShowEndStationMap.Refresh();
            }
            else
            {
                btnShowEndStationMap.Enabled = false;
                //Image ändern
                btnShowEndStationMap.Image = global::WindowsFormsApplication1.Properties.Resources.imgres_disabled;
            }
        }

        private void stationBoardDropdown_TextChanged(object sender, EventArgs e)
        {
            if (stationBoardDropdown.Text.Length > 0)
            {
                btnShowStationBoardMap.Enabled = true;
                //Image ändern
                btnShowStationBoardMap.Image = global::WindowsFormsApplication1.Properties.Resources.imgres;
                btnShowStationBoardMap.Refresh();
            }
            else
            {
                btnShowStationBoardMap.Enabled = false;
                //Image ändern
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

        private void enableConnectionButton()
        {
            if (startStationDropdown.Text.Length > 0 && endStationDropdown.Text.Length > 0)
            {
                cmdShowConnections.Enabled = true;
            }
            else
            {
                cmdShowConnections.Enabled = false;
            }
        }
    }
}