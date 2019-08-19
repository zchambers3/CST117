using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CST_117_Milestone_3
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        List<InventoryManager> invList = new List<InventoryManager>(); //List to store objects
        List<string> nameList = new List<string>(); //List to store Item Names
        List<string> prodIdList = new List<string>(); //List to store product IDs

        private void GetInvData(InventoryManager inv)
        {
            decimal price; 
            int quant;

            //Verify there is data in the TextBoxes
            if(nameTextBox.Text != "" && productTextBox.Text != "" && quantTextBox.Text !="" && priceTextBox.Text != "")
            {
                if (decimal.TryParse(priceTextBox.Text,out price) && int.TryParse(quantTextBox.Text, out quant))
                {
                    inv.Name = nameTextBox.Text;
                    inv.ProdId = productTextBox.Text;
                    inv.Quant = quant;
                    inv.Price = price;
                }
                else
                {
                    MessageBox.Show("Invalid Quantity or Price");
                }
            }

            //Find the TextBox with no data
            else
            {
                if (nameTextBox.Text == "")
                {
                    MessageBox.Show("Invalid input for Name");
                }
                if (productTextBox.Text == "")
                {
                    MessageBox.Show("Invalid input for Product ID");
                }
                if (quantTextBox.Text == "")
                {
                    MessageBox.Show("Invalid input for Quantity");
                }
                if (priceTextBox.Text == "")
                {
                    MessageBox.Show("Invalid input for Price");
                }
            }
        }
        private void addButton_Click(object sender, EventArgs e)
        {
            InventoryManager newInv = new InventoryManager(); //Create a new inventory oject
            GetInvData(newInv); //Set values in object
            invList.Add(newInv); //Add object to a list so it can be referenced later
            itemListBox.Items.Add(newInv.Name + " " + newInv.ProdId); //Concat name and Product ID
            nameList.Add(nameTextBox.Text); //Add name to list (used for search and index)
            prodIdList.Add(productTextBox.Text); //Add poduct ID to list (used for search and index)

            //Clear all the TextBoxes for new data
            nameTextBox.Clear();
            productTextBox.Clear();
            quantTextBox.Clear();
            priceTextBox.Clear();
            nameTextBox.Focus();
        }

        private void itemListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = itemListBox.SelectedIndex; //Get the position of the selected item
            if (index != -1) //Make sure an item is selected
            {
                //Set label values
                nameLabel.Text = invList[index].Name; 
                prodLabel.Text = invList[index].ProdId;
                //Set TextBox values
                quantUpdateTextBox.Text = invList[index].Quant.ToString("n0");
                priceUpdateTextBox.Text = invList[index].Price.ToString("n2");
            } 
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            bool found = false; //bool used to indicate if search value found

            if (searchTextBox.Text != "" && nameList.Count > 0) //Make sure there is data in the texbox and an item in the list
            {
                for (int x=0; x < nameList.Count; x++) //Check all the values in the name list
                {
                    if (searchTextBox.Text == nameList[x]) 
                    {
                        found = true; //Change bool to indicate item found

                        //Update labels and textboxes with found item
                        nameLabel.Text = invList[x].Name;
                        prodLabel.Text = invList[x].ProdId;
                        quantUpdateTextBox.Text = invList[x].Quant.ToString("n0");
                        priceUpdateTextBox.Text = invList[x].Price.ToString("n2");

                        itemListBox.SelectedIndex = x; //changed selected item in listbox
                    }
                }

                for (int x = 0; x < prodIdList.Count; x++) //Check all the values in the prod ID list
                {
                    if (searchTextBox.Text == prodIdList[x]) //Check if indexed item matches textbox
                    {
                        found = true;//Change bool to indicate item found

                        //Update labels and textboxes with found item
                        nameLabel.Text = invList[x].Name;
                        prodLabel.Text = invList[x].ProdId;
                        quantUpdateTextBox.Text = invList[x].Quant.ToString("n0");
                        priceUpdateTextBox.Text = invList[x].Price.ToString("n2");

                        itemListBox.SelectedIndex = x; //changed selected item in listbox
                    }
                }

                if (found == false) //Let the user know the item couldn't be found
                {
                    MessageBox.Show("Product Name or ID cannot be found!");
                }
            }
            else //Invalid data or not list items
            {
                MessageBox.Show("Invalid input for Search or no items in inventory!");
            }
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            int index = itemListBox.SelectedIndex; //Get the position of the selected item
            if (index != -1) //Make sure an item is selected
            {
                //remove items from list and clear labels and textboxes
                nameList.RemoveAt(index);
                prodIdList.RemoveAt(index);
                invList.RemoveAt(index);
                itemListBox.Items.RemoveAt(index);
                nameLabel.Text = "";
                prodLabel.Text = "";
                quantUpdateTextBox.Text = "";
                priceUpdateTextBox.Text = "";
                itemListBox.ClearSelected();

            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close(); //close application
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            int index = itemListBox.SelectedIndex; //Get the position of the selected item
            if (index != -1) //Make sure an item is selected
            {
                //update object with new price or quantity
                decimal newPrice;
                int newQuant;
                decimal.TryParse(priceUpdateTextBox.Text, out newPrice);
                int.TryParse(quantUpdateTextBox.Text, out newQuant);
                invList[index].Price = newPrice;
                invList[index].Quant = newQuant;
            }
        }
    }
}
