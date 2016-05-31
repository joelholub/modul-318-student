namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cmdShowConnections = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.endStationDropdown = new System.Windows.Forms.ComboBox();
            this.startStationDropdown = new System.Windows.Forms.ComboBox();
            this.lvConnections = new System.Windows.Forms.ListView();
            this.Abfahrt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AbfahrtStation = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Ankunft = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Ankunftstation = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Reisezeit = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel8 = new System.Windows.Forms.Panel();
            this.btnShowEndStationMap = new System.Windows.Forms.PictureBox();
            this.btnShowStartStationMap = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnShowStationBoardMap = new System.Windows.Forms.PictureBox();
            this.cmdStationBoard = new System.Windows.Forms.Button();
            this.lvDepartureTable = new System.Windows.Forms.ListView();
            this.clmnAbfahrtStation = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmnName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmnAbfahrtsZeit = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmnTo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.stationBoardDropdown = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnShowEndStationMap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnShowStartStationMap)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnShowStationBoardMap)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdShowConnections
            // 
            this.cmdShowConnections.Location = new System.Drawing.Point(6, 81);
            this.cmdShowConnections.Name = "cmdShowConnections";
            this.cmdShowConnections.Size = new System.Drawing.Size(158, 23);
            this.cmdShowConnections.TabIndex = 0;
            this.cmdShowConnections.Text = "Verbindungen anzeigen";
            this.cmdShowConnections.UseVisualStyleBackColor = true;
            this.cmdShowConnections.Click += new System.EventHandler(this.cmdShowConnections_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Startstation:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Endstation:";
            // 
            // endStationDropdown
            // 
            this.endStationDropdown.FormattingEnabled = true;
            this.endStationDropdown.Location = new System.Drawing.Point(89, 34);
            this.endStationDropdown.Name = "endStationDropdown";
            this.endStationDropdown.Size = new System.Drawing.Size(208, 21);
            this.endStationDropdown.TabIndex = 8;
            this.endStationDropdown.DropDown += new System.EventHandler(this.endStationDropdown_DropDown);
            this.endStationDropdown.TextUpdate += new System.EventHandler(this.endStationDropdown_TextUpdate);
            this.endStationDropdown.TextChanged += new System.EventHandler(this.endStationDropdown_TextChanged);
            // 
            // startStationDropdown
            // 
            this.startStationDropdown.FormattingEnabled = true;
            this.startStationDropdown.Location = new System.Drawing.Point(89, 9);
            this.startStationDropdown.Name = "startStationDropdown";
            this.startStationDropdown.Size = new System.Drawing.Size(208, 21);
            this.startStationDropdown.TabIndex = 7;
            this.startStationDropdown.DropDown += new System.EventHandler(this.startStationDropdown_DropDown);
            this.startStationDropdown.TextUpdate += new System.EventHandler(this.startStationDropdown_TextUpdate);
            this.startStationDropdown.TextChanged += new System.EventHandler(this.startStationDropdown_TextChanged);
            // 
            // lvConnections
            // 
            this.lvConnections.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Abfahrt,
            this.AbfahrtStation,
            this.Ankunft,
            this.Ankunftstation,
            this.Reisezeit});
            this.lvConnections.Location = new System.Drawing.Point(6, 126);
            this.lvConnections.Name = "lvConnections";
            this.lvConnections.Size = new System.Drawing.Size(655, 157);
            this.lvConnections.TabIndex = 13;
            this.lvConnections.UseCompatibleStateImageBehavior = false;
            this.lvConnections.View = System.Windows.Forms.View.Details;
            // 
            // Abfahrt
            // 
            this.Abfahrt.Text = "Abfahrt";
            this.Abfahrt.Width = 72;
            // 
            // AbfahrtStation
            // 
            this.AbfahrtStation.Text = "Abfahrt Station";
            this.AbfahrtStation.Width = 196;
            // 
            // Ankunft
            // 
            this.Ankunft.Text = "Ankunft";
            this.Ankunft.Width = 70;
            // 
            // Ankunftstation
            // 
            this.Ankunftstation.Text = "Ankunftstation";
            this.Ankunftstation.Width = 188;
            // 
            // Reisezeit
            // 
            this.Reisezeit.Text = "Reisezeit";
            this.Reisezeit.Width = 124;
            // 
            // panel8
            // 
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel8.Controls.Add(this.btnShowEndStationMap);
            this.panel8.Controls.Add(this.btnShowStartStationMap);
            this.panel8.Controls.Add(this.endStationDropdown);
            this.panel8.Controls.Add(this.label1);
            this.panel8.Controls.Add(this.label2);
            this.panel8.Controls.Add(this.startStationDropdown);
            this.panel8.Location = new System.Drawing.Point(6, 6);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(327, 66);
            this.panel8.TabIndex = 15;
            // 
            // btnShowEndStationMap
            // 
            this.btnShowEndStationMap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowEndStationMap.Enabled = false;
            this.btnShowEndStationMap.Image = global::WindowsFormsApplication1.Properties.Resources.imgres_disabled;
            this.btnShowEndStationMap.Location = new System.Drawing.Point(300, 32);
            this.btnShowEndStationMap.Name = "btnShowEndStationMap";
            this.btnShowEndStationMap.Size = new System.Drawing.Size(22, 23);
            this.btnShowEndStationMap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnShowEndStationMap.TabIndex = 18;
            this.btnShowEndStationMap.TabStop = false;
            this.btnShowEndStationMap.Click += new System.EventHandler(this.btnShowEndStationMap_Click);
            // 
            // btnShowStartStationMap
            // 
            this.btnShowStartStationMap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowStartStationMap.Enabled = false;
            this.btnShowStartStationMap.Image = ((System.Drawing.Image)(resources.GetObject("btnShowStartStationMap.Image")));
            this.btnShowStartStationMap.Location = new System.Drawing.Point(300, 7);
            this.btnShowStartStationMap.Name = "btnShowStartStationMap";
            this.btnShowStartStationMap.Size = new System.Drawing.Size(22, 23);
            this.btnShowStartStationMap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnShowStartStationMap.TabIndex = 17;
            this.btnShowStartStationMap.TabStop = false;
            this.btnShowStartStationMap.Click += new System.EventHandler(this.btnShowStartStationMap_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(684, 336);
            this.tabControl1.TabIndex = 17;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel8);
            this.tabPage1.Controls.Add(this.cmdShowConnections);
            this.tabPage1.Controls.Add(this.lvConnections);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(676, 310);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Verbindungen Suchen";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnShowStationBoardMap);
            this.tabPage2.Controls.Add(this.cmdStationBoard);
            this.tabPage2.Controls.Add(this.lvDepartureTable);
            this.tabPage2.Controls.Add(this.stationBoardDropdown);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(676, 310);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Abfahrtstafel";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnShowStationBoardMap
            // 
            this.btnShowStationBoardMap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowStationBoardMap.Enabled = false;
            this.btnShowStationBoardMap.Image = ((System.Drawing.Image)(resources.GetObject("btnShowStationBoardMap.Image")));
            this.btnShowStationBoardMap.Location = new System.Drawing.Point(247, 10);
            this.btnShowStationBoardMap.Name = "btnShowStationBoardMap";
            this.btnShowStationBoardMap.Size = new System.Drawing.Size(22, 23);
            this.btnShowStationBoardMap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnShowStationBoardMap.TabIndex = 19;
            this.btnShowStationBoardMap.TabStop = false;
            this.btnShowStationBoardMap.Click += new System.EventHandler(this.btnShowStationBoardMap_Click);
            // 
            // cmdStationBoard
            // 
            this.cmdStationBoard.Location = new System.Drawing.Point(11, 46);
            this.cmdStationBoard.Name = "cmdStationBoard";
            this.cmdStationBoard.Size = new System.Drawing.Size(152, 23);
            this.cmdStationBoard.TabIndex = 3;
            this.cmdStationBoard.Text = "Abfahrtstafel generieren";
            this.cmdStationBoard.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cmdStationBoard.UseVisualStyleBackColor = true;
            this.cmdStationBoard.Click += new System.EventHandler(this.cmdStationBoard_Click);
            // 
            // lvDepartureTable
            // 
            this.lvDepartureTable.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmnAbfahrtStation,
            this.clmnName,
            this.clmnAbfahrtsZeit,
            this.clmnTo});
            this.lvDepartureTable.Location = new System.Drawing.Point(11, 75);
            this.lvDepartureTable.Name = "lvDepartureTable";
            this.lvDepartureTable.Size = new System.Drawing.Size(656, 224);
            this.lvDepartureTable.TabIndex = 2;
            this.lvDepartureTable.UseCompatibleStateImageBehavior = false;
            this.lvDepartureTable.View = System.Windows.Forms.View.Details;
            // 
            // clmnAbfahrtStation
            // 
            this.clmnAbfahrtStation.Text = "Abfahrtstation";
            this.clmnAbfahrtStation.Width = 138;
            // 
            // clmnName
            // 
            this.clmnName.Text = "Name";
            this.clmnName.Width = 112;
            // 
            // clmnAbfahrtsZeit
            // 
            this.clmnAbfahrtsZeit.Text = "Abfahrtszeit";
            this.clmnAbfahrtsZeit.Width = 120;
            // 
            // clmnTo
            // 
            this.clmnTo.Text = "Endstation";
            this.clmnTo.Width = 157;
            // 
            // stationBoardDropdown
            // 
            this.stationBoardDropdown.FormattingEnabled = true;
            this.stationBoardDropdown.Location = new System.Drawing.Point(54, 12);
            this.stationBoardDropdown.Name = "stationBoardDropdown";
            this.stationBoardDropdown.Size = new System.Drawing.Size(187, 21);
            this.stationBoardDropdown.TabIndex = 1;
            this.stationBoardDropdown.DropDown += new System.EventHandler(this.stationBoardDropdown_DropDown);
            this.stationBoardDropdown.TextUpdate += new System.EventHandler(this.stationBoardDropdown_TextUpdate);
            this.stationBoardDropdown.TextChanged += new System.EventHandler(this.stationBoardDropdown_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Station";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 333);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Fahrplan Tool";
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnShowEndStationMap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnShowStartStationMap)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnShowStationBoardMap)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdShowConnections;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox endStationDropdown;
        private System.Windows.Forms.ComboBox startStationDropdown;
        private System.Windows.Forms.ListView lvConnections;
        private System.Windows.Forms.ColumnHeader Abfahrt;
        private System.Windows.Forms.ColumnHeader AbfahrtStation;
        private System.Windows.Forms.ColumnHeader Ankunft;
        private System.Windows.Forms.ColumnHeader Ankunftstation;
        private System.Windows.Forms.ColumnHeader Reisezeit;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button cmdStationBoard;
        private System.Windows.Forms.ListView lvDepartureTable;
        private System.Windows.Forms.ComboBox stationBoardDropdown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ColumnHeader clmnAbfahrtStation;
        private System.Windows.Forms.ColumnHeader clmnAbfahrtsZeit;
        private System.Windows.Forms.ColumnHeader clmnName;
        private System.Windows.Forms.ColumnHeader clmnTo;
        private System.Windows.Forms.PictureBox btnShowEndStationMap;
        private System.Windows.Forms.PictureBox btnShowStartStationMap;
        private System.Windows.Forms.PictureBox btnShowStationBoardMap;
    }
}

