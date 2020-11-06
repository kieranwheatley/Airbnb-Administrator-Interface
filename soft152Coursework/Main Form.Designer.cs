namespace soft152Coursework
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ofdInputFile = new System.Windows.Forms.OpenFileDialog();
            this.lstDistricts = new System.Windows.Forms.ListBox();
            this.btnSelectData = new System.Windows.Forms.Button();
            this.lstNeighbourhoods = new System.Windows.Forms.ListBox();
            this.lstProperties = new System.Windows.Forms.ListBox();
            this.lblDistricts = new System.Windows.Forms.Label();
            this.lblNeighbourhood = new System.Windows.Forms.Label();
            this.lblProperties = new System.Windows.Forms.Label();
            this.btnDistrictEdit = new System.Windows.Forms.Button();
            this.txtDistrictName = new System.Windows.Forms.TextBox();
            this.txtDstNumNeigh = new System.Windows.Forms.TextBox();
            this.lblEditDistrictName = new System.Windows.Forms.Label();
            this.lblDistrictNumNeighbourhoods = new System.Windows.Forms.Label();
            this.btnSaveDistrict = new System.Windows.Forms.Button();
            this.btnNeighbourhoodEdit = new System.Windows.Forms.Button();
            this.txtLatitude = new System.Windows.Forms.TextBox();
            this.lblLatitude = new System.Windows.Forms.Label();
            this.txtLongitude = new System.Windows.Forms.TextBox();
            this.lblLongitude = new System.Windows.Forms.Label();
            this.txtHostID = new System.Windows.Forms.TextBox();
            this.lblHostNumListings = new System.Windows.Forms.Label();
            this.lblHostID = new System.Windows.Forms.Label();
            this.txtHostListings = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblHostName = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtHostName = new System.Windows.Forms.TextBox();
            this.txtMinimumNights = new System.Windows.Forms.TextBox();
            this.txtPropertyID = new System.Windows.Forms.TextBox();
            this.lblMinimumNights = new System.Windows.Forms.Label();
            this.txtPropertyName = new System.Windows.Forms.TextBox();
            this.txtAvailableNights = new System.Windows.Forms.TextBox();
            this.lblPropName = new System.Windows.Forms.Label();
            this.txtRoomType = new System.Windows.Forms.TextBox();
            this.lblAvailableNights = new System.Windows.Forms.Label();
            this.lblPropertyID = new System.Windows.Forms.Label();
            this.lblRoomType = new System.Windows.Forms.Label();
            this.grpProperty = new System.Windows.Forms.GroupBox();
            this.btnPropertyAdd = new System.Windows.Forms.Button();
            this.btnPropertyUpdate = new System.Windows.Forms.Button();
            this.grpEditDistrict = new System.Windows.Forms.GroupBox();
            this.btnAddDistrict = new System.Windows.Forms.Button();
            this.btnNeighbourhoodAdd = new System.Windows.Forms.Button();
            this.btnDistrictAdd = new System.Windows.Forms.Button();
            this.btnDeleteProperty = new System.Windows.Forms.Button();
            this.btnPropertyEdit = new System.Windows.Forms.Button();
            this.btnPropertyNew = new System.Windows.Forms.Button();
            this.grpEditNeighbourhood = new System.Windows.Forms.GroupBox();
            this.txtNeighbourhoodName = new System.Windows.Forms.TextBox();
            this.lblNeighbourhoodName = new System.Windows.Forms.Label();
            this.txtNeighNumProps = new System.Windows.Forms.TextBox();
            this.lblNeighNumProps = new System.Windows.Forms.Label();
            this.btnSaveNeighbourhood = new System.Windows.Forms.Button();
            this.btnSaveFile = new System.Windows.Forms.Button();
            this.btnAddNeighbourhood = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grpProperty.SuspendLayout();
            this.grpEditDistrict.SuspendLayout();
            this.grpEditNeighbourhood.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(632, 198);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // ofdInputFile
            // 
            this.ofdInputFile.FileName = "openFileDialog1";
            // 
            // lstDistricts
            // 
            this.lstDistricts.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstDistricts.FormattingEnabled = true;
            this.lstDistricts.ItemHeight = 20;
            this.lstDistricts.Location = new System.Drawing.Point(4, 233);
            this.lstDistricts.Name = "lstDistricts";
            this.lstDistricts.Size = new System.Drawing.Size(632, 84);
            this.lstDistricts.TabIndex = 3;
            this.lstDistricts.SelectedIndexChanged += new System.EventHandler(this.lstDistricts_SelectedIndexChanged);
            // 
            // btnSelectData
            // 
            this.btnSelectData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectData.Location = new System.Drawing.Point(256, 175);
            this.btnSelectData.Name = "btnSelectData";
            this.btnSelectData.Size = new System.Drawing.Size(136, 26);
            this.btnSelectData.TabIndex = 2;
            this.btnSelectData.Text = "Select Data File";
            this.btnSelectData.UseVisualStyleBackColor = true;
            this.btnSelectData.Click += new System.EventHandler(this.BtnSelectData_Click);
            // 
            // lstNeighbourhoods
            // 
            this.lstNeighbourhoods.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstNeighbourhoods.FormattingEnabled = true;
            this.lstNeighbourhoods.ItemHeight = 20;
            this.lstNeighbourhoods.Location = new System.Drawing.Point(4, 409);
            this.lstNeighbourhoods.Name = "lstNeighbourhoods";
            this.lstNeighbourhoods.Size = new System.Drawing.Size(632, 84);
            this.lstNeighbourhoods.TabIndex = 4;
            this.lstNeighbourhoods.SelectedIndexChanged += new System.EventHandler(this.lstNeighbourhoods_SelectedIndexChanged);
            // 
            // lstProperties
            // 
            this.lstProperties.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstProperties.FormattingEnabled = true;
            this.lstProperties.ItemHeight = 20;
            this.lstProperties.Location = new System.Drawing.Point(2, 600);
            this.lstProperties.Name = "lstProperties";
            this.lstProperties.Size = new System.Drawing.Size(632, 84);
            this.lstProperties.TabIndex = 5;
            this.lstProperties.SelectedIndexChanged += new System.EventHandler(this.lstProperties_SelectedIndexChanged);
            // 
            // lblDistricts
            // 
            this.lblDistricts.AutoSize = true;
            this.lblDistricts.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDistricts.Location = new System.Drawing.Point(-2, 204);
            this.lblDistricts.Name = "lblDistricts";
            this.lblDistricts.Size = new System.Drawing.Size(90, 26);
            this.lblDistricts.TabIndex = 6;
            this.lblDistricts.Text = "Districts";
            // 
            // lblNeighbourhood
            // 
            this.lblNeighbourhood.AutoSize = true;
            this.lblNeighbourhood.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNeighbourhood.Location = new System.Drawing.Point(-1, 380);
            this.lblNeighbourhood.Name = "lblNeighbourhood";
            this.lblNeighbourhood.Size = new System.Drawing.Size(171, 26);
            this.lblNeighbourhood.TabIndex = 7;
            this.lblNeighbourhood.Text = "Neighbourhoods";
            // 
            // lblProperties
            // 
            this.lblProperties.AutoSize = true;
            this.lblProperties.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProperties.Location = new System.Drawing.Point(-1, 574);
            this.lblProperties.Name = "lblProperties";
            this.lblProperties.Size = new System.Drawing.Size(111, 26);
            this.lblProperties.TabIndex = 8;
            this.lblProperties.Text = "Properties";
            // 
            // btnDistrictEdit
            // 
            this.btnDistrictEdit.Enabled = false;
            this.btnDistrictEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDistrictEdit.Location = new System.Drawing.Point(562, 210);
            this.btnDistrictEdit.Name = "btnDistrictEdit";
            this.btnDistrictEdit.Size = new System.Drawing.Size(75, 23);
            this.btnDistrictEdit.TabIndex = 11;
            this.btnDistrictEdit.Text = "Edit";
            this.btnDistrictEdit.UseVisualStyleBackColor = true;
            this.btnDistrictEdit.Click += new System.EventHandler(this.BtnDistrictEdit_Click);
            // 
            // txtDistrictName
            // 
            this.txtDistrictName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDistrictName.Location = new System.Drawing.Point(260, 9);
            this.txtDistrictName.Name = "txtDistrictName";
            this.txtDistrictName.Size = new System.Drawing.Size(294, 27);
            this.txtDistrictName.TabIndex = 9;
            // 
            // txtDstNumNeigh
            // 
            this.txtDstNumNeigh.Enabled = false;
            this.txtDstNumNeigh.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDstNumNeigh.Location = new System.Drawing.Point(260, 41);
            this.txtDstNumNeigh.Name = "txtDstNumNeigh";
            this.txtDstNumNeigh.Size = new System.Drawing.Size(49, 27);
            this.txtDstNumNeigh.TabIndex = 10;
            // 
            // lblEditDistrictName
            // 
            this.lblEditDistrictName.AutoSize = true;
            this.lblEditDistrictName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditDistrictName.Location = new System.Drawing.Point(138, 12);
            this.lblEditDistrictName.Name = "lblEditDistrictName";
            this.lblEditDistrictName.Size = new System.Drawing.Size(122, 22);
            this.lblEditDistrictName.TabIndex = 12;
            this.lblEditDistrictName.Text = "District Name:";
            // 
            // lblDistrictNumNeighbourhoods
            // 
            this.lblDistrictNumNeighbourhoods.AutoSize = true;
            this.lblDistrictNumNeighbourhoods.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDistrictNumNeighbourhoods.Location = new System.Drawing.Point(51, 44);
            this.lblDistrictNumNeighbourhoods.Name = "lblDistrictNumNeighbourhoods";
            this.lblDistrictNumNeighbourhoods.Size = new System.Drawing.Size(209, 22);
            this.lblDistrictNumNeighbourhoods.TabIndex = 13;
            this.lblDistrictNumNeighbourhoods.Text = "Num of Neighbourhoods:";
            // 
            // btnSaveDistrict
            // 
            this.btnSaveDistrict.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveDistrict.Location = new System.Drawing.Point(550, 9);
            this.btnSaveDistrict.Name = "btnSaveDistrict";
            this.btnSaveDistrict.Size = new System.Drawing.Size(80, 27);
            this.btnSaveDistrict.TabIndex = 14;
            this.btnSaveDistrict.Text = "Update";
            this.btnSaveDistrict.UseVisualStyleBackColor = true;
            this.btnSaveDistrict.Click += new System.EventHandler(this.btnSaveDistrict_Click);
            // 
            // btnNeighbourhoodEdit
            // 
            this.btnNeighbourhoodEdit.Enabled = false;
            this.btnNeighbourhoodEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNeighbourhoodEdit.Location = new System.Drawing.Point(562, 386);
            this.btnNeighbourhoodEdit.Name = "btnNeighbourhoodEdit";
            this.btnNeighbourhoodEdit.Size = new System.Drawing.Size(75, 23);
            this.btnNeighbourhoodEdit.TabIndex = 21;
            this.btnNeighbourhoodEdit.Text = "Edit";
            this.btnNeighbourhoodEdit.UseVisualStyleBackColor = true;
            this.btnNeighbourhoodEdit.Click += new System.EventHandler(this.btnNeighbourhoodEdit_Click);
            // 
            // txtLatitude
            // 
            this.txtLatitude.Enabled = false;
            this.txtLatitude.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLatitude.Location = new System.Drawing.Point(465, 101);
            this.txtLatitude.Name = "txtLatitude";
            this.txtLatitude.Size = new System.Drawing.Size(100, 25);
            this.txtLatitude.TabIndex = 35;
            // 
            // lblLatitude
            // 
            this.lblLatitude.AutoSize = true;
            this.lblLatitude.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLatitude.Location = new System.Drawing.Point(394, 104);
            this.lblLatitude.Name = "lblLatitude";
            this.lblLatitude.Size = new System.Drawing.Size(71, 20);
            this.lblLatitude.TabIndex = 34;
            this.lblLatitude.Text = "Latitude:";
            // 
            // txtLongitude
            // 
            this.txtLongitude.Enabled = false;
            this.txtLongitude.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLongitude.Location = new System.Drawing.Point(465, 132);
            this.txtLongitude.Name = "txtLongitude";
            this.txtLongitude.Size = new System.Drawing.Size(100, 25);
            this.txtLongitude.TabIndex = 33;
            // 
            // lblLongitude
            // 
            this.lblLongitude.AutoSize = true;
            this.lblLongitude.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLongitude.Location = new System.Drawing.Point(381, 135);
            this.lblLongitude.Name = "lblLongitude";
            this.lblLongitude.Size = new System.Drawing.Size(84, 20);
            this.lblLongitude.TabIndex = 32;
            this.lblLongitude.Text = "Longitude:";
            // 
            // txtHostID
            // 
            this.txtHostID.Enabled = false;
            this.txtHostID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHostID.Location = new System.Drawing.Point(144, 135);
            this.txtHostID.Name = "txtHostID";
            this.txtHostID.Size = new System.Drawing.Size(138, 25);
            this.txtHostID.TabIndex = 43;
            // 
            // lblHostNumListings
            // 
            this.lblHostNumListings.AutoSize = true;
            this.lblHostNumListings.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHostNumListings.Location = new System.Drawing.Point(2, 168);
            this.lblHostNumListings.Name = "lblHostNumListings";
            this.lblHostNumListings.Size = new System.Drawing.Size(142, 20);
            this.lblHostNumListings.TabIndex = 31;
            this.lblHostNumListings.Text = "Host Num Listings:";
            // 
            // lblHostID
            // 
            this.lblHostID.AutoSize = true;
            this.lblHostID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHostID.Location = new System.Drawing.Point(76, 138);
            this.lblHostID.Name = "lblHostID";
            this.lblHostID.Size = new System.Drawing.Size(68, 20);
            this.lblHostID.TabIndex = 44;
            this.lblHostID.Text = "Host ID:";
            // 
            // txtHostListings
            // 
            this.txtHostListings.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHostListings.Location = new System.Drawing.Point(144, 165);
            this.txtHostListings.Name = "txtHostListings";
            this.txtHostListings.Size = new System.Drawing.Size(85, 25);
            this.txtHostListings.TabIndex = 30;
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(465, 39);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(100, 25);
            this.txtPrice.TabIndex = 45;
            // 
            // lblHostName
            // 
            this.lblHostName.AutoSize = true;
            this.lblHostName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHostName.Location = new System.Drawing.Point(51, 104);
            this.lblHostName.Name = "lblHostName";
            this.lblHostName.Size = new System.Drawing.Size(93, 20);
            this.lblHostName.TabIndex = 29;
            this.lblHostName.Text = "Host Name:";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(349, 42);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(116, 20);
            this.lblPrice.TabIndex = 46;
            this.lblPrice.Text = "Price per Night:";
            // 
            // txtHostName
            // 
            this.txtHostName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHostName.Location = new System.Drawing.Point(144, 101);
            this.txtHostName.Name = "txtHostName";
            this.txtHostName.Size = new System.Drawing.Size(244, 25);
            this.txtHostName.TabIndex = 28;
            // 
            // txtMinimumNights
            // 
            this.txtMinimumNights.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMinimumNights.Location = new System.Drawing.Point(465, 70);
            this.txtMinimumNights.Name = "txtMinimumNights";
            this.txtMinimumNights.Size = new System.Drawing.Size(100, 25);
            this.txtMinimumNights.TabIndex = 47;
            // 
            // txtPropertyID
            // 
            this.txtPropertyID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPropertyID.Location = new System.Drawing.Point(144, 39);
            this.txtPropertyID.Name = "txtPropertyID";
            this.txtPropertyID.Size = new System.Drawing.Size(100, 25);
            this.txtPropertyID.TabIndex = 24;
            // 
            // lblMinimumNights
            // 
            this.lblMinimumNights.AutoSize = true;
            this.lblMinimumNights.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinimumNights.Location = new System.Drawing.Point(340, 73);
            this.lblMinimumNights.Name = "lblMinimumNights";
            this.lblMinimumNights.Size = new System.Drawing.Size(125, 20);
            this.lblMinimumNights.TabIndex = 48;
            this.lblMinimumNights.Text = "Minimum Nights:";
            // 
            // txtPropertyName
            // 
            this.txtPropertyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPropertyName.Location = new System.Drawing.Point(144, 8);
            this.txtPropertyName.Name = "txtPropertyName";
            this.txtPropertyName.Size = new System.Drawing.Size(470, 25);
            this.txtPropertyName.TabIndex = 23;
            // 
            // txtAvailableNights
            // 
            this.txtAvailableNights.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAvailableNights.Location = new System.Drawing.Point(465, 164);
            this.txtAvailableNights.Name = "txtAvailableNights";
            this.txtAvailableNights.Size = new System.Drawing.Size(100, 25);
            this.txtAvailableNights.TabIndex = 49;
            // 
            // lblPropName
            // 
            this.lblPropName.AutoSize = true;
            this.lblPropName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPropName.Location = new System.Drawing.Point(26, 11);
            this.lblPropName.Name = "lblPropName";
            this.lblPropName.Size = new System.Drawing.Size(118, 20);
            this.lblPropName.TabIndex = 22;
            this.lblPropName.Text = "Property Name:";
            // 
            // txtRoomType
            // 
            this.txtRoomType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRoomType.Location = new System.Drawing.Point(144, 70);
            this.txtRoomType.Name = "txtRoomType";
            this.txtRoomType.Size = new System.Drawing.Size(190, 25);
            this.txtRoomType.TabIndex = 52;
            // 
            // lblAvailableNights
            // 
            this.lblAvailableNights.AutoSize = true;
            this.lblAvailableNights.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvailableNights.Location = new System.Drawing.Point(262, 168);
            this.lblAvailableNights.Name = "lblAvailableNights";
            this.lblAvailableNights.Size = new System.Drawing.Size(203, 20);
            this.lblAvailableNights.TabIndex = 50;
            this.lblAvailableNights.Text = "Number of Available Nights:";
            // 
            // lblPropertyID
            // 
            this.lblPropertyID.AutoSize = true;
            this.lblPropertyID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPropertyID.Location = new System.Drawing.Point(51, 42);
            this.lblPropertyID.Name = "lblPropertyID";
            this.lblPropertyID.Size = new System.Drawing.Size(93, 20);
            this.lblPropertyID.TabIndex = 25;
            this.lblPropertyID.Text = "Property ID:\r\n";
            // 
            // lblRoomType
            // 
            this.lblRoomType.AutoSize = true;
            this.lblRoomType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomType.Location = new System.Drawing.Point(4, 73);
            this.lblRoomType.Name = "lblRoomType";
            this.lblRoomType.Size = new System.Drawing.Size(140, 20);
            this.lblRoomType.TabIndex = 51;
            this.lblRoomType.Text = "Room Description:";
            // 
            // grpProperty
            // 
            this.grpProperty.Controls.Add(this.btnPropertyAdd);
            this.grpProperty.Controls.Add(this.btnPropertyUpdate);
            this.grpProperty.Controls.Add(this.lblRoomType);
            this.grpProperty.Controls.Add(this.lblPropertyID);
            this.grpProperty.Controls.Add(this.lblAvailableNights);
            this.grpProperty.Controls.Add(this.txtRoomType);
            this.grpProperty.Controls.Add(this.lblPropName);
            this.grpProperty.Controls.Add(this.txtAvailableNights);
            this.grpProperty.Controls.Add(this.txtPropertyName);
            this.grpProperty.Controls.Add(this.lblMinimumNights);
            this.grpProperty.Controls.Add(this.txtPropertyID);
            this.grpProperty.Controls.Add(this.txtMinimumNights);
            this.grpProperty.Controls.Add(this.txtHostName);
            this.grpProperty.Controls.Add(this.lblPrice);
            this.grpProperty.Controls.Add(this.lblHostName);
            this.grpProperty.Controls.Add(this.txtPrice);
            this.grpProperty.Controls.Add(this.txtHostListings);
            this.grpProperty.Controls.Add(this.lblHostID);
            this.grpProperty.Controls.Add(this.lblHostNumListings);
            this.grpProperty.Controls.Add(this.txtHostID);
            this.grpProperty.Controls.Add(this.lblLongitude);
            this.grpProperty.Controls.Add(this.txtLongitude);
            this.grpProperty.Controls.Add(this.lblLatitude);
            this.grpProperty.Controls.Add(this.txtLatitude);
            this.grpProperty.Location = new System.Drawing.Point(2, 690);
            this.grpProperty.Name = "grpProperty";
            this.grpProperty.Size = new System.Drawing.Size(633, 195);
            this.grpProperty.TabIndex = 51;
            this.grpProperty.TabStop = false;
            this.grpProperty.Visible = false;
            // 
            // btnPropertyAdd
            // 
            this.btnPropertyAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPropertyAdd.Location = new System.Drawing.Point(568, 39);
            this.btnPropertyAdd.Name = "btnPropertyAdd";
            this.btnPropertyAdd.Size = new System.Drawing.Size(59, 53);
            this.btnPropertyAdd.TabIndex = 54;
            this.btnPropertyAdd.Text = "Add Property";
            this.btnPropertyAdd.UseVisualStyleBackColor = true;
            this.btnPropertyAdd.Click += new System.EventHandler(this.btnPropertyAdd_Click);
            // 
            // btnPropertyUpdate
            // 
            this.btnPropertyUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPropertyUpdate.Location = new System.Drawing.Point(568, 135);
            this.btnPropertyUpdate.Name = "btnPropertyUpdate";
            this.btnPropertyUpdate.Size = new System.Drawing.Size(59, 54);
            this.btnPropertyUpdate.TabIndex = 53;
            this.btnPropertyUpdate.Text = "Update";
            this.btnPropertyUpdate.UseVisualStyleBackColor = true;
            this.btnPropertyUpdate.Visible = false;
            this.btnPropertyUpdate.Click += new System.EventHandler(this.btnPropertyUpdate_Click);
            // 
            // grpEditDistrict
            // 
            this.grpEditDistrict.Controls.Add(this.btnAddDistrict);
            this.grpEditDistrict.Controls.Add(this.txtDistrictName);
            this.grpEditDistrict.Controls.Add(this.txtDstNumNeigh);
            this.grpEditDistrict.Controls.Add(this.lblEditDistrictName);
            this.grpEditDistrict.Controls.Add(this.lblDistrictNumNeighbourhoods);
            this.grpEditDistrict.Controls.Add(this.btnSaveDistrict);
            this.grpEditDistrict.Location = new System.Drawing.Point(4, 314);
            this.grpEditDistrict.Name = "grpEditDistrict";
            this.grpEditDistrict.Size = new System.Drawing.Size(633, 72);
            this.grpEditDistrict.TabIndex = 53;
            this.grpEditDistrict.TabStop = false;
            this.grpEditDistrict.Visible = false;
            // 
            // btnAddDistrict
            // 
            this.btnAddDistrict.Location = new System.Drawing.Point(521, 45);
            this.btnAddDistrict.Name = "btnAddDistrict";
            this.btnAddDistrict.Size = new System.Drawing.Size(112, 27);
            this.btnAddDistrict.TabIndex = 21;
            this.btnAddDistrict.Text = "Add District";
            this.btnAddDistrict.UseVisualStyleBackColor = true;
            this.btnAddDistrict.Click += new System.EventHandler(this.btnAddDistrict_Click);
            // 
            // btnNeighbourhoodAdd
            // 
            this.btnNeighbourhoodAdd.Enabled = false;
            this.btnNeighbourhoodAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNeighbourhoodAdd.Location = new System.Drawing.Point(485, 386);
            this.btnNeighbourhoodAdd.Name = "btnNeighbourhoodAdd";
            this.btnNeighbourhoodAdd.Size = new System.Drawing.Size(75, 23);
            this.btnNeighbourhoodAdd.TabIndex = 54;
            this.btnNeighbourhoodAdd.Text = "Add";
            this.btnNeighbourhoodAdd.UseVisualStyleBackColor = true;
            this.btnNeighbourhoodAdd.Click += new System.EventHandler(this.btnNeighbourhoodAdd_Click);
            // 
            // btnDistrictAdd
            // 
            this.btnDistrictAdd.Enabled = false;
            this.btnDistrictAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDistrictAdd.Location = new System.Drawing.Point(486, 210);
            this.btnDistrictAdd.Name = "btnDistrictAdd";
            this.btnDistrictAdd.Size = new System.Drawing.Size(74, 23);
            this.btnDistrictAdd.TabIndex = 55;
            this.btnDistrictAdd.Text = "Add";
            this.btnDistrictAdd.UseVisualStyleBackColor = true;
            this.btnDistrictAdd.Click += new System.EventHandler(this.btnDistrictAdd_Click);
            // 
            // btnDeleteProperty
            // 
            this.btnDeleteProperty.Enabled = false;
            this.btnDeleteProperty.Location = new System.Drawing.Point(544, 571);
            this.btnDeleteProperty.Name = "btnDeleteProperty";
            this.btnDeleteProperty.Size = new System.Drawing.Size(90, 23);
            this.btnDeleteProperty.TabIndex = 56;
            this.btnDeleteProperty.Text = "Delete Property";
            this.btnDeleteProperty.UseVisualStyleBackColor = true;
            this.btnDeleteProperty.Click += new System.EventHandler(this.btnDeleteProperty_Click);
            // 
            // btnPropertyEdit
            // 
            this.btnPropertyEdit.Enabled = false;
            this.btnPropertyEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPropertyEdit.Location = new System.Drawing.Point(469, 571);
            this.btnPropertyEdit.Name = "btnPropertyEdit";
            this.btnPropertyEdit.Size = new System.Drawing.Size(75, 23);
            this.btnPropertyEdit.TabIndex = 20;
            this.btnPropertyEdit.Text = "Edit";
            this.btnPropertyEdit.UseVisualStyleBackColor = true;
            this.btnPropertyEdit.Click += new System.EventHandler(this.btnPropertyEdit_Click);
            // 
            // btnPropertyNew
            // 
            this.btnPropertyNew.Enabled = false;
            this.btnPropertyNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPropertyNew.Location = new System.Drawing.Point(394, 571);
            this.btnPropertyNew.Name = "btnPropertyNew";
            this.btnPropertyNew.Size = new System.Drawing.Size(75, 23);
            this.btnPropertyNew.TabIndex = 20;
            this.btnPropertyNew.Text = "Add";
            this.btnPropertyNew.UseVisualStyleBackColor = true;
            this.btnPropertyNew.Click += new System.EventHandler(this.btnPropertyNew_Click);
            // 
            // grpEditNeighbourhood
            // 
            this.grpEditNeighbourhood.Controls.Add(this.btnAddNeighbourhood);
            this.grpEditNeighbourhood.Controls.Add(this.txtNeighbourhoodName);
            this.grpEditNeighbourhood.Controls.Add(this.lblNeighbourhoodName);
            this.grpEditNeighbourhood.Controls.Add(this.txtNeighNumProps);
            this.grpEditNeighbourhood.Controls.Add(this.lblNeighNumProps);
            this.grpEditNeighbourhood.Controls.Add(this.btnSaveNeighbourhood);
            this.grpEditNeighbourhood.Location = new System.Drawing.Point(3, 499);
            this.grpEditNeighbourhood.Name = "grpEditNeighbourhood";
            this.grpEditNeighbourhood.Size = new System.Drawing.Size(640, 72);
            this.grpEditNeighbourhood.TabIndex = 57;
            this.grpEditNeighbourhood.TabStop = false;
            this.grpEditNeighbourhood.Visible = false;
            // 
            // txtNeighbourhoodName
            // 
            this.txtNeighbourhoodName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNeighbourhoodName.Location = new System.Drawing.Point(262, 7);
            this.txtNeighbourhoodName.Name = "txtNeighbourhoodName";
            this.txtNeighbourhoodName.Size = new System.Drawing.Size(294, 27);
            this.txtNeighbourhoodName.TabIndex = 15;
            // 
            // lblNeighbourhoodName
            // 
            this.lblNeighbourhoodName.AutoSize = true;
            this.lblNeighbourhoodName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNeighbourhoodName.Location = new System.Drawing.Point(72, 10);
            this.lblNeighbourhoodName.Name = "lblNeighbourhoodName";
            this.lblNeighbourhoodName.Size = new System.Drawing.Size(190, 22);
            this.lblNeighbourhoodName.TabIndex = 16;
            this.lblNeighbourhoodName.Text = "Neighbourhood Name:";
            // 
            // txtNeighNumProps
            // 
            this.txtNeighNumProps.Enabled = false;
            this.txtNeighNumProps.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNeighNumProps.Location = new System.Drawing.Point(262, 40);
            this.txtNeighNumProps.Name = "txtNeighNumProps";
            this.txtNeighNumProps.Size = new System.Drawing.Size(47, 27);
            this.txtNeighNumProps.TabIndex = 17;
            // 
            // lblNeighNumProps
            // 
            this.lblNeighNumProps.AutoSize = true;
            this.lblNeighNumProps.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNeighNumProps.Location = new System.Drawing.Point(103, 43);
            this.lblNeighNumProps.Name = "lblNeighNumProps";
            this.lblNeighNumProps.Size = new System.Drawing.Size(159, 22);
            this.lblNeighNumProps.TabIndex = 18;
            this.lblNeighNumProps.Text = "Num of Properties:";
            // 
            // btnSaveNeighbourhood
            // 
            this.btnSaveNeighbourhood.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveNeighbourhood.Location = new System.Drawing.Point(552, 7);
            this.btnSaveNeighbourhood.Name = "btnSaveNeighbourhood";
            this.btnSaveNeighbourhood.Size = new System.Drawing.Size(79, 27);
            this.btnSaveNeighbourhood.TabIndex = 19;
            this.btnSaveNeighbourhood.Text = "Update";
            this.btnSaveNeighbourhood.UseVisualStyleBackColor = true;
            // 
            // btnSaveFile
            // 
            this.btnSaveFile.Location = new System.Drawing.Point(551, 178);
            this.btnSaveFile.Name = "btnSaveFile";
            this.btnSaveFile.Size = new System.Drawing.Size(85, 23);
            this.btnSaveFile.TabIndex = 60;
            this.btnSaveFile.Text = "Save Changes";
            this.btnSaveFile.UseVisualStyleBackColor = true;
            this.btnSaveFile.Visible = false;
            this.btnSaveFile.Click += new System.EventHandler(this.btnSaveFile_Click);
            // 
            // btnAddNeighbourhood
            // 
            this.btnAddNeighbourhood.Location = new System.Drawing.Point(519, 38);
            this.btnAddNeighbourhood.Name = "btnAddNeighbourhood";
            this.btnAddNeighbourhood.Size = new System.Drawing.Size(112, 27);
            this.btnAddNeighbourhood.TabIndex = 21;
            this.btnAddNeighbourhood.Text = "Add Neighbourhood";
            this.btnAddNeighbourhood.UseVisualStyleBackColor = true;
            this.btnAddNeighbourhood.Click += new System.EventHandler(this.btnAddNeighbourhood_Click_2);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(637, 886);
            this.Controls.Add(this.btnSaveFile);
            this.Controls.Add(this.grpEditNeighbourhood);
            this.Controls.Add(this.btnPropertyNew);
            this.Controls.Add(this.btnDeleteProperty);
            this.Controls.Add(this.btnPropertyEdit);
            this.Controls.Add(this.btnDistrictAdd);
            this.Controls.Add(this.btnNeighbourhoodAdd);
            this.Controls.Add(this.lblNeighbourhood);
            this.Controls.Add(this.grpEditDistrict);
            this.Controls.Add(this.lblProperties);
            this.Controls.Add(this.grpProperty);
            this.Controls.Add(this.btnNeighbourhoodEdit);
            this.Controls.Add(this.btnDistrictEdit);
            this.Controls.Add(this.lblDistricts);
            this.Controls.Add(this.lstNeighbourhoods);
            this.Controls.Add(this.lstDistricts);
            this.Controls.Add(this.btnSelectData);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lstProperties);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "Airbnb - Admin ";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grpProperty.ResumeLayout(false);
            this.grpProperty.PerformLayout();
            this.grpEditDistrict.ResumeLayout(false);
            this.grpEditDistrict.PerformLayout();
            this.grpEditNeighbourhood.ResumeLayout(false);
            this.grpEditNeighbourhood.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog ofdInputFile;
        private System.Windows.Forms.ListBox lstDistricts;
        private System.Windows.Forms.Button btnSelectData;
        private System.Windows.Forms.ListBox lstNeighbourhoods;
        private System.Windows.Forms.ListBox lstProperties;
        private System.Windows.Forms.Label lblDistricts;
        private System.Windows.Forms.Label lblNeighbourhood;
        private System.Windows.Forms.Label lblProperties;
        private System.Windows.Forms.Button btnDistrictEdit;
        private System.Windows.Forms.TextBox txtDistrictName;
        private System.Windows.Forms.TextBox txtDstNumNeigh;
        private System.Windows.Forms.Label lblEditDistrictName;
        private System.Windows.Forms.Label lblDistrictNumNeighbourhoods;
        private System.Windows.Forms.Button btnSaveDistrict;
        private System.Windows.Forms.Button btnNeighbourhoodEdit;
        private System.Windows.Forms.TextBox txtLatitude;
        private System.Windows.Forms.Label lblLatitude;
        private System.Windows.Forms.TextBox txtLongitude;
        private System.Windows.Forms.Label lblLongitude;
        private System.Windows.Forms.TextBox txtHostID;
        private System.Windows.Forms.Label lblHostNumListings;
        private System.Windows.Forms.Label lblHostID;
        private System.Windows.Forms.TextBox txtHostListings;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblHostName;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtHostName;
        private System.Windows.Forms.TextBox txtMinimumNights;
        private System.Windows.Forms.TextBox txtPropertyID;
        private System.Windows.Forms.Label lblMinimumNights;
        private System.Windows.Forms.TextBox txtPropertyName;
        private System.Windows.Forms.TextBox txtAvailableNights;
        private System.Windows.Forms.Label lblPropName;
        private System.Windows.Forms.TextBox txtRoomType;
        private System.Windows.Forms.Label lblAvailableNights;
        private System.Windows.Forms.Label lblPropertyID;
        private System.Windows.Forms.Label lblRoomType;
        private System.Windows.Forms.GroupBox grpProperty;
        private System.Windows.Forms.Button btnPropertyUpdate;
        private System.Windows.Forms.GroupBox grpEditDistrict;
        private System.Windows.Forms.Button btnPropertyAdd;
        private System.Windows.Forms.Button btnNeighbourhoodAdd;
        private System.Windows.Forms.Button btnDistrictAdd;
        private System.Windows.Forms.Button btnAddDistrict;
        private System.Windows.Forms.Button btnDeleteProperty;
        private System.Windows.Forms.Button btnPropertyEdit;
        private System.Windows.Forms.Button btnPropertyNew;
        private System.Windows.Forms.GroupBox grpEditNeighbourhood;
        private System.Windows.Forms.TextBox txtNeighbourhoodName;
        private System.Windows.Forms.Label lblNeighbourhoodName;
        private System.Windows.Forms.TextBox txtNeighNumProps;
        private System.Windows.Forms.Label lblNeighNumProps;
        private System.Windows.Forms.Button btnSaveNeighbourhood;
        private System.Windows.Forms.Button btnSaveFile;
        private System.Windows.Forms.Button btnAddNeighbourhood;
    }
}

