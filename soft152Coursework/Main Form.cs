using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace soft152Coursework
{
    public partial class frmMain : Form
    {
        //Global variables
        String filename;
        public static frmMain thisForm;
        StreamReader inputData;
        StreamWriter outputData;
        District[] AllDistricts = new District[0];
        Neighbourhood[] districtAllNeighbourhoods = new Neighbourhood[0];
        Property[] neighbourhoodAllProperties = new Property[0];
        int whichDistrict = -1;
        int whichNeighbourhood = -1;
        int whichProperty = -1;
        bool districtEditOpen = false;
        bool neighbourhoodEditOpen = false;
        bool propertyEditOpen = false;
        bool districtAddOpen = false;
        public frmMain()
        {
            InitializeComponent();
            thisForm = this;
        }   
        private void BtnSelectData_Click(object sender, EventArgs e)
        {
            lstDistricts.Items.Clear();
            ofdInputFile.ShowDialog();
            filename = ofdInputFile.FileName;
            setUpFiles();
            displayDistricts();
        }
        private void lstDistricts_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnNeighbourhoodAdd.Enabled = true;
            if (whichProperty == -1)
            {
                whichDistrict = lstDistricts.SelectedIndex;
                displayNeighbourhoods(whichDistrict);
                btnDistrictEdit.Enabled = true;
                btnDistrictAdd.Enabled = true;
                whichNeighbourhood = -1;
                whichProperty = -1;
                
            }
            else if (whichProperty != -1)
            {
                whichNeighbourhood = -1;
                whichProperty = -1;
                clearLstNeighbourhood();
                clearLstProperties();
                displayNeighbourhoods(whichDistrict);
            }
        }
        private void lstNeighbourhoods_SelectedIndexChanged(object sender, EventArgs e)
        {
            whichNeighbourhood = lstNeighbourhoods.SelectedIndex;
            displayProperties(whichDistrict, whichNeighbourhood);
            btnNeighbourhoodEdit.Enabled = true;
            btnPropertyNew.Enabled = true;
        }
        private void lstProperties_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (whichProperty == -1)
            {
                whichProperty = lstProperties.SelectedIndex;
                btnPropertyEdit.Enabled = true;
                btnPropertyNew.Enabled = true;
                btnDeleteProperty.Visible = true;
                btnDeleteProperty.Enabled = true;
            }
        }
        private void FrmMain_Load(object sender, EventArgs e)
        {
            thisForm.Height = 245;
        }
        private void BtnDistrictEdit_Click(object sender, EventArgs e)
        {
            editDistrict();
            btnSaveDistrict.Visible = true;
            btnAddDistrict.Visible = false;
        }

        private void btnSaveDistrict_Click(object sender, EventArgs e)
        {
            applyEditDistrict();
        }
        private void btnPropertyUpdate_Click(object sender, EventArgs e)
        {
            applyPropertyEdit();
            saveToFile();
        }
        private void btnPropertyEdit_Click(object sender, EventArgs e)
        {
            editProperty();
        }
        private void btnNeighbourhoodEdit_Click(object sender, EventArgs e)
        {
            editNeighbourhood();
            btnSaveNeighbourhood.Visible = true;
        }
        private void btnSaveNeighbourhood_Click(object sender, EventArgs e)
        {
            applyNeighbourhoodEdit();
        }
        private void btnNeighbourhoodAdd_Click(object sender, EventArgs e)
        {
            grpEditNeighbourhood.Visible = true;
            btnSaveNeighbourhood.Visible = false;
            btnAddNeighbourhood.Visible = true;
            txtNeighbourhoodName.Text = "";
            txtNeighNumProps.Text = "";

            if (btnNeighbourhoodEdit.Visible == true)
            {
                btnNeighbourhoodEdit.Visible = false;
            }
            else if (btnNeighbourhoodEdit.Visible == false)
            {
                btnNeighbourhoodEdit.Visible = true;
                grpEditNeighbourhood.Visible = false;
            }
        }
        private void btnPropertyAdd_Click(object sender, EventArgs e)
        {
            addProperty();
        }
        private void btnPropertyNew_Click(object sender, EventArgs e)
        {
            clearInput();
            showAddProp();
            thisForm.Height = 925;
            if (btnPropertyEdit.Visible == true)
            {
                btnPropertyEdit.Visible = false;
            }
            else if (btnPropertyEdit.Visible == false)
            {
                btnPropertyEdit.Visible = true;
                grpProperty.Visible = false;
                thisForm.Height = 725;
            }
        }
        private void btnAddNeighbourhood_Click(object sender, EventArgs e)
        {
            addNeighbourhood();
        }

        private void btnDistrictAdd_Click(object sender, EventArgs e)
        {
            grpEditDistrict.Visible = true;
            btnSaveDistrict.Visible = false;
            btnAddDistrict.Visible = true;
            txtDistrictName.Text = "";
            txtDstNumNeigh.Text = "";
            if (btnDistrictEdit.Visible == true)
            {
                btnDistrictEdit.Visible = false;
            }
            else if (btnDistrictEdit.Visible == false)
            {
                btnDistrictEdit.Visible = true;
                grpEditDistrict.Visible = false;
            }
        }
        private void btnAddDistrict_Click(object sender, EventArgs e)
        {
            addDistrict();
        }
        private void btnDeleteProperty_Click(object sender, EventArgs e)
        {
            removeProperty();
        }
        private void btnSaveFile_Click(object sender, EventArgs e)
        {
            saveToFile();
        }

        private void btnAddNeighbourhood_Click_2(object sender, EventArgs e)
        {
            addNeighbourhood();
        }
        //------------------------------------------------------------Methods------------------------------------------------------------------------//

        //Create stream reader and input from file, creating the districts, neighbourhoods, and properties and storing them appropriately
        private void setUpFiles()
        {
            //Create filestream
            inputData = new StreamReader(filename);
            while (!inputData.EndOfStream)
            {
                //Property
                string thePropertyID, thePropertyName, theHostID, thePropHostName,
                        theHostNumListings, thePropLat, thePropLong, thePropRoomType;
                int thePropPrice, thePropMinNights, thePropAvailNights;
                //Neighbourhood
                string inNeighbourhoodName;
                int inNeighbourhoodProperties;
                //District
                string inDistrictName;
                int inDistrictNeighbourhoods;
                inDistrictName = inputData.ReadLine();
                inDistrictNeighbourhoods = Convert.ToInt32(inputData.ReadLine());
                Neighbourhood[] tempNeighbourhood = new Neighbourhood[inDistrictNeighbourhoods];
                for (int DistrictNeighbourhoods = 0; DistrictNeighbourhoods < inDistrictNeighbourhoods; DistrictNeighbourhoods++)
                {
                    inNeighbourhoodName = inputData.ReadLine();
                    inNeighbourhoodProperties = Convert.ToInt32(inputData.ReadLine());
                    Property[] tempProperties = new Property[inNeighbourhoodProperties];
                    for (int properties = 0; properties < inNeighbourhoodProperties; properties++)
                    {
                        thePropertyID = inputData.ReadLine();
                        thePropertyName = inputData.ReadLine();
                        theHostID = inputData.ReadLine();
                        thePropHostName = inputData.ReadLine();
                        theHostNumListings = inputData.ReadLine();
                        thePropLat = inputData.ReadLine();
                        thePropLong = inputData.ReadLine();
                        thePropRoomType = inputData.ReadLine();
                        thePropPrice = Convert.ToInt32(inputData.ReadLine());
                        thePropMinNights = Convert.ToInt32(inputData.ReadLine());
                        thePropAvailNights = Convert.ToInt32(inputData.ReadLine());
                        Property tempProperty = new Property(thePropertyID, thePropertyName, theHostID,
                                                            thePropHostName, theHostNumListings, thePropLat,
                                                            thePropLong, thePropRoomType, thePropPrice,
                                                            thePropMinNights, thePropAvailNights);
                        tempProperties[properties] = tempProperty;
                    }
                    Neighbourhood tempNeighbourhoods = new Neighbourhood(inNeighbourhoodName, inNeighbourhoodProperties, tempProperties);
                    tempNeighbourhood[DistrictNeighbourhoods] = tempNeighbourhoods;
                }
                District tempDistrict = new District(inDistrictName, inDistrictNeighbourhoods, tempNeighbourhood);
                Array.Resize(ref AllDistricts, AllDistricts.Length + 1);
                AllDistricts[AllDistricts.Length - 1] = tempDistrict;
            }
            inputData.Close();
            thisForm.Height = 725;
            btnSelectData.Visible = false;
            btnSaveFile.Visible = true;
        }
        //Method for writing the data back to the file to save changes made.
        private void saveToFile()
        {
            outputData = new StreamWriter(filename);
            int count = 0;
            try
            {
                foreach (District d in AllDistricts)
                {
                    outputData.WriteLine(d.getDistrictName());
                    outputData.WriteLine(d.getDistrictProperties());
                    foreach (Neighbourhood n in d.districtAllNeighbourhoods)
                    {
                        outputData.WriteLine(n.getNeighbourhoodName());
                        outputData.WriteLine(n.getNeighbourhoodProperties());
                        foreach (Property p in n.neighbourhoodAllProperties)
                        {
                            count++;
                            outputData.WriteLine(p.getPropID());
                            outputData.WriteLine(p.getPropName());
                            outputData.WriteLine(p.getHostID());
                            outputData.WriteLine(p.getHostName());
                            outputData.WriteLine(p.getHostNumListings());
                            outputData.WriteLine(p.getPropLat());
                            outputData.WriteLine(p.getPropLong());
                            outputData.WriteLine(p.getPropRoomType());
                            outputData.WriteLine(p.getPropPrice());
                            outputData.WriteLine(p.getPropMinNights());
                            outputData.WriteLine(p.getPropAvailNights());
                        }
                    }
                }
                MessageBox.Show("Changes have been saved successfully!");
                outputData.Close();
            }
            
            catch (IOException)
            {
                MessageBox.Show("There was an error saving the data. Please contact IT support.");
            }
        }
        //Method for populating the Districts list box with all Districts in the allDistricts array
        private void displayDistricts()
        {
            clearLstDistrict();
            foreach (District d in AllDistricts)
            {
                lstDistricts.Items.Add(d.getDistrictName() + ". Neighbourhoods: " + d.getDistrictProperties());
            }
        }
        //Method for populating the Neighbourhoods list box with Neighbourhoods from the SELECTED District
        private void displayNeighbourhoods(int whichDistrict)
        {
            try
            {
                clearLstNeighbourhood();
                Neighbourhood[] tempNeighbourhood = AllDistricts[whichDistrict].GetNeighbourhoods();
                foreach (Neighbourhood n in tempNeighbourhood)
                {
                    lstNeighbourhoods.Items.Add(n.getNeighbourhoodName() + ". Num of Properties: " + n.getNeighbourhoodProperties());
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show(AllDistricts[whichDistrict].getDistrictName() + " has no Neighbourhoods. Please add them.");
            }
        }
        //Method for populating the properties list box with Properties from the SELECTED District && Neighbourhood
        private void displayProperties(int whichDistrict, int whichNeighbourhood)
        {
            try
            {
                clearLstProperties();
                Neighbourhood[] tempNeighbourhood = AllDistricts[whichDistrict].GetNeighbourhoods();
                Property[] tempProperties = tempNeighbourhood[whichNeighbourhood].GetProperties();
                foreach (Property p in tempProperties)
                {
                    lstProperties.Items.Add(p.getPropName() + " | Host(s): " + p.getHostName());
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show(AllDistricts[whichDistrict].districtAllNeighbourhoods[whichNeighbourhood].getNeighbourhoodName() + " has no Properties! Please add them.");
            }
        }
        //Method for clearing the Districts list box
        private void clearLstDistrict()
        {
            lstDistricts.Items.Clear();
        }
        //Method for clearing the Neighbourhoods list box
        private void clearLstNeighbourhood()
        {
            lstNeighbourhoods.Items.Clear();
        }
        //Method for clearing the Properties list box
        private void clearLstProperties()
        {
            lstProperties.Items.Clear();
        }
        //Method for setting up the edit district options
        private void editDistrict()
        {
            if (districtEditOpen == false && whichDistrict != -1)
            {
                grpEditDistrict.Visible = true;
                txtDistrictName.Text = AllDistricts[whichDistrict].getDistrictName();
                txtDstNumNeigh.Text = AllDistricts[whichDistrict].getDistrictProperties();
                districtEditOpen = true;
                btnDistrictAdd.Visible = false;
            }
            else if (districtEditOpen == true)
            {
                grpEditDistrict.Visible = false;
                districtEditOpen = false;
                btnDistrictAdd.Visible = true;
            }
        }
        //Method for setting up the edit neighbourhood options
        private void editNeighbourhood()
        {
            if (neighbourhoodEditOpen == false && whichNeighbourhood != -1)
            {
                grpEditNeighbourhood.Visible = true;
                txtNeighbourhoodName.Text = AllDistricts[whichDistrict].districtAllNeighbourhoods[whichNeighbourhood].getNeighbourhoodName();
                txtNeighNumProps.Text = AllDistricts[whichDistrict].districtAllNeighbourhoods[whichNeighbourhood].getNeighbourhoodProperties();
                neighbourhoodEditOpen = true;
                btnNeighbourhoodAdd.Visible = false;
                btnAddNeighbourhood.Visible = false;
            }
            else if (neighbourhoodEditOpen == true)
            {
                grpEditNeighbourhood.Visible = false;
                neighbourhoodEditOpen = false;
                btnNeighbourhoodAdd.Visible = true;
                btnAddNeighbourhood.Visible = true;
            }
        }
        //Method for setting up the edit property options
        private void editProperty()
        {
            if (propertyEditOpen == false && whichProperty != -1)
            {
                thisForm.Height = 925;
                grpProperty.Visible = true;
                propertyEditOpen = true;
                btnPropertyNew.Visible = false;
                btnPropertyUpdate.Visible = true;
                txtHostID.Enabled = false;
                txtLatitude.Enabled = false;
                txtLongitude.Enabled = false;

                txtPropertyID.Text = AllDistricts[whichDistrict].districtAllNeighbourhoods[whichNeighbourhood].neighbourhoodAllProperties[whichProperty].getPropID();
                txtPropertyName.Text = AllDistricts[whichDistrict].districtAllNeighbourhoods[whichNeighbourhood].neighbourhoodAllProperties[whichProperty].getPropName();
                txtHostName.Text = AllDistricts[whichDistrict].districtAllNeighbourhoods[whichNeighbourhood].neighbourhoodAllProperties[whichProperty].getHostName();
                txtHostID.Text = AllDistricts[whichDistrict].districtAllNeighbourhoods[whichNeighbourhood].neighbourhoodAllProperties[whichProperty].getHostID();
                txtHostListings.Text = AllDistricts[whichDistrict].districtAllNeighbourhoods[whichNeighbourhood].neighbourhoodAllProperties[whichProperty].getHostNumListings();
                txtRoomType.Text = AllDistricts[whichDistrict].districtAllNeighbourhoods[whichNeighbourhood].neighbourhoodAllProperties[whichProperty].getPropRoomType();
                txtLatitude.Text = AllDistricts[whichDistrict].districtAllNeighbourhoods[whichNeighbourhood].neighbourhoodAllProperties[whichProperty].getPropLat();
                txtLongitude.Text = AllDistricts[whichDistrict].districtAllNeighbourhoods[whichNeighbourhood].neighbourhoodAllProperties[whichProperty].getPropLong();
                txtPrice.Text = Convert.ToString(AllDistricts[whichDistrict].districtAllNeighbourhoods[whichNeighbourhood].neighbourhoodAllProperties[whichProperty].getPropPrice());
                txtAvailableNights.Text = Convert.ToString(AllDistricts[whichDistrict].districtAllNeighbourhoods[whichNeighbourhood].neighbourhoodAllProperties[whichProperty].getPropAvailNights());
                txtMinimumNights.Text = Convert.ToString(AllDistricts[whichDistrict].districtAllNeighbourhoods[whichNeighbourhood].neighbourhoodAllProperties[whichProperty].getPropMinNights());
            }
            else if (propertyEditOpen == true)
            {
                grpProperty.Visible = false;
                thisForm.Height = 725;
                propertyEditOpen = false;
                btnPropertyUpdate.Visible = false;
                btnPropertyNew.Visible = true;
            }
        }
        //Method for setting up the add District options
        private void showAddDistrict()
        {
            if (districtAddOpen == false)
            {
                grpEditDistrict.Visible = true;
                btnDistrictEdit.Visible = false;
                btnSaveDistrict.Visible = false;
                btnAddDistrict.Visible = true;
                districtAddOpen = true;
            }
            else if (districtAddOpen == true)
            {
                grpEditDistrict.Visible = false;
                btnDistrictEdit.Visible = true;
                btnSaveDistrict.Visible = true;
                btnAddDistrict.Visible = false;
                districtAddOpen = false;
            }
        }
        //Method for updating a District's name
        private void applyEditDistrict()
        {
            AllDistricts[whichDistrict].setDistrictName(txtDistrictName.Text);
            displayDistricts();
        }
        //Method for updating a Neighbourhood's name
        private void applyNeighbourhoodEdit()
        {
            AllDistricts[whichDistrict].districtAllNeighbourhoods[whichNeighbourhood].setNeighbourhoodName(txtNeighbourhoodName.Text);
            displayDistricts();
            displayNeighbourhoods(whichDistrict);
        }
        //Method for updating a property's details
        private void applyPropertyEdit()
        {
            string propID = txtPropertyID.Text;
            string propertyName = txtPropertyName.Text;
            string propHostID = txtHostID.Text;
            string propHostName = txtHostName.Text;
            string propHostNumListings = txtHostListings.Text;
            string propLat = txtLatitude.Text;
            string propLong = txtLongitude.Text;
            string propRoomType = txtRoomType.Text;
            string propPrice = txtPrice.Text;
            string propMinNights = txtMinimumNights.Text;
            string propAvailNights = txtAvailableNights.Text;
            Property tempProperty = new Property(propID, propertyName, propHostID, propHostName,
                propHostNumListings, propLat, propLong, propRoomType, Convert.ToInt32(propPrice),
                Convert.ToInt32(propMinNights), Convert.ToInt32(propAvailNights));
            AllDistricts[whichDistrict].districtAllNeighbourhoods[whichNeighbourhood].neighbourhoodAllProperties[whichProperty] = tempProperty;
            clearLstDistrict();
            clearLstNeighbourhood();
            clearLstProperties();
            displayDistricts();
            displayNeighbourhoods(whichDistrict);
            displayProperties(whichDistrict, whichNeighbourhood);
        }
        //Method for adding a new District to the array and refreshing the display to show it.
        private void addDistrict()
        {
            string districtName = txtDistrictName.Text;
            District tempDistrict = new District(districtName);
            int length = AllDistricts.Length;
            Array.Resize(ref AllDistricts, length + 1);
            AllDistricts[length] = tempDistrict;
            clearLstDistrict();
            clearLstNeighbourhood();
            clearLstProperties();
            clearInput();
            displayDistricts();
            displayNeighbourhoods(whichDistrict);
            whichNeighbourhood = -1;
            whichProperty = -1;
        }
        //Method for adding a new Neighbourhood to the specified District's Neighbourhood array and refreshing the display to show it.
        private void addNeighbourhood()
        {
            string neighbourhoodName = txtNeighbourhoodName.Text;
            Neighbourhood tempNeighbourhood = new Neighbourhood(neighbourhoodName);
            int length = AllDistricts[whichDistrict].getIntNumNeighbourhoods();
            Array.Resize(ref AllDistricts[whichDistrict].districtAllNeighbourhoods, length + 1);
            AllDistricts[whichDistrict].districtAllNeighbourhoods[length] = tempNeighbourhood;
            int newNumNeighbourhoods = (Convert.ToInt32(AllDistricts[whichDistrict].getDistrictProperties()) + 1);
            AllDistricts[whichDistrict].setDistrictNeighbourhoods(Convert.ToString(newNumNeighbourhoods));
            clearLstDistrict();
            clearLstNeighbourhood();
            clearLstProperties();
            clearInput();
            displayDistricts();
            displayNeighbourhoods(whichDistrict);
            whichProperty = -1;
        }
        //Method for adding a new Property to the specified Neighbourhood's Propereties array and refreshing the display to show it.
        private void addProperty()
        {
            string propID = txtPropertyID.Text;
            string propertyName = txtPropertyName.Text;
            string propHostID = txtHostID.Text;
            string propHostName = txtHostName.Text;
            string propHostNumListings = txtHostListings.Text;
            string propLat = txtLatitude.Text;
            string propLong = txtLongitude.Text;
            string propRoomType = txtRoomType.Text;
            string propPrice = txtPrice.Text;
            string propMinNights = txtMinimumNights.Text;
            string propAvailNights = txtAvailableNights.Text;
            Property tempProperty = new Property(propID, propertyName, propHostID, propHostName,
                propHostNumListings, propLat, propLong, propRoomType, Convert.ToInt32(propPrice),
                Convert.ToInt32(propMinNights), Convert.ToInt32(propAvailNights));
            int length = AllDistricts[whichDistrict].districtAllNeighbourhoods[whichNeighbourhood].getIntNumProperties();
            Array.Resize(ref AllDistricts[whichDistrict].districtAllNeighbourhoods[whichNeighbourhood].neighbourhoodAllProperties, length + 1);
            AllDistricts[whichDistrict].districtAllNeighbourhoods[whichNeighbourhood].neighbourhoodAllProperties[length] = tempProperty;
            int newNumProps = (Convert.ToInt32(AllDistricts[whichDistrict].districtAllNeighbourhoods[whichNeighbourhood].getNeighbourhoodProperties()) + 1);
            AllDistricts[whichDistrict].districtAllNeighbourhoods[whichNeighbourhood].setNeighbourhoodProperties(Convert.ToString(newNumProps));
            clearLstNeighbourhood();
            clearLstProperties();
            clearInput();
            displayNeighbourhoods(whichDistrict);
            displayProperties(whichDistrict, whichNeighbourhood);
        }
        //Method for removing a property from the Neighbourhood array it is in and resizing the array. It then refreshes the display to show the removal.
        private void removeProperty()
        {
            {
                int remove = whichProperty;
                int length = AllDistricts[whichDistrict].districtAllNeighbourhoods[whichNeighbourhood].getIntNumProperties();
                int i = 0;
                int j = 0;
                Property[] newProperties = new Property[length - 1];
                Property[] tempProperty = new Property[length - 1];
                tempProperty = AllDistricts[whichDistrict].districtAllNeighbourhoods[whichNeighbourhood].GetProperties();
                while (i < tempProperty.Length)
                {
                    if (i != remove)
                    {
                        newProperties[j] = tempProperty[i];
                        j++;
                    }
                    i++;
                }
                AllDistricts[whichDistrict].districtAllNeighbourhoods[whichNeighbourhood].setProperties(newProperties);
            }
            int newNumProps = (Convert.ToInt32(AllDistricts[whichDistrict].districtAllNeighbourhoods[whichNeighbourhood].getNeighbourhoodProperties()) - 1);
            AllDistricts[whichDistrict].districtAllNeighbourhoods[whichNeighbourhood].setNeighbourhoodProperties(Convert.ToString(newNumProps));
            clearLstNeighbourhood();
            clearLstProperties();
            clearInput();
            displayNeighbourhoods(whichDistrict);
            displayProperties(whichDistrict, whichNeighbourhood);
        }
        //Method for setting up the Property group to allow for adding a new Property (the text boxes that are disabled are only used when adding a new property
        //as they are not to be editted.
        private void showAddProp()
        {
            thisForm.Height = 925;
            grpProperty.Visible = true;
            txtHostID.Enabled = true;
            txtLatitude.Enabled = true;
            txtLongitude.Enabled = true;
        }
        //Method for clearing the text boxes in the Property group boxes
        private void clearInput()
        {
            txtPropertyID.Clear();
            txtPropertyName.Clear();
            txtHostID.Clear();
            txtHostName.Clear();
            txtHostListings.Clear();
            txtLatitude.Clear();
            txtLongitude.Clear();
            txtRoomType.Clear();
            txtPrice.Clear();
            txtMinimumNights.Clear();
            txtAvailableNights.Clear();
        }
    }
}
