using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaApp2
{
    public partial class Form1 : Form
    {

        // Lists to store toppings and pizzas
        private List<string> availableToppings = new List<string>();
        private List<Pizza> pizzas = new List<Pizza>();

        public Form1()
        {
            InitializeComponent();
            InitializeData();
        }

        // Pizza class to store the toppings and pizza data
        public class Pizza
        {
            public string Name { get; set; }
            public List<string> Toppings { get; set; }

            public Pizza(string name)
            {
                Name = name;
                Toppings = new List<string>();
            }
        }
        //Adding initial toppings and premade pizzas
        private void InitializeData()
        {
            availableToppings.AddRange(new string[] { "Pepperoni", "Mushrooms", "Onions", "Sausage", "Olives", "Bacon" });
            LoadToppingsToListBox(); // Load inital toppings
            LoadToppingsToCheckedListBox();

            //Creating premade pizza named veggie lovers
            Pizza pizza1 = new Pizza("Veggie Lovers");
            pizza1.Toppings.AddRange(new string[] { "Onions", "Olives", "Mushrooms" });
            pizzas.Add(pizza1);

            LoadPizzasToDataGridView(); // Load initial pizzas
        }

        private void LoadToppingsToListBox()
        {
            listBoxToppings.Items.Clear();
            listBoxToppings.Items.AddRange(availableToppings.ToArray());
        }

        private void LoadToppingsToCheckedListBox()
        {
            checkedListBoxPizzaToppings.Items.Clear();
            foreach (var topping in availableToppings)
            {
                checkedListBoxPizzaToppings.Items.Add(topping);
            }
        }

        private void LoadPizzasToDataGridView()
        {
            dataGridViewPizzas.DataSource = null; // Clear existing data
            dataGridViewPizzas.AutoGenerateColumns = false;


            // Name columns for pizza grid
            dataGridViewPizzas.Columns.Clear(); // Clear existing columns
            dataGridViewPizzas.Columns.Add("PizzaNameColumn", "Pizza Name");
            dataGridViewPizzas.Columns.Add("PizzaToppingsColumn", "Toppings");

            // Adding pizza data
            foreach (var pizza in pizzas)
            {
                dataGridViewPizzas.Rows.Add(pizza.Name, string.Join(", ", pizza.Toppings));
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            buttonEditTopping.Enabled = true;
            buttonEditPizza.Enabled = true;
            buttonDeletePizza.Enabled = true;
        }

        private void buttonAddTopping_Click(object sender, EventArgs e)
        {
            string newTopping = textBoxNewTopping.Text.Trim();
            if (!string.IsNullOrEmpty(newTopping) && !availableToppings.Contains(newTopping))
            {
                availableToppings.Add(newTopping);

                // Sort toppings alphabetically
                availableToppings.Sort();

                // Refresh list
                LoadToppingsToListBox();
                LoadToppingsToCheckedListBox();

                // Clear textbox
                textBoxNewTopping.Clear(); 
            }
            else if (string.IsNullOrEmpty(newTopping))
            {
                MessageBox.Show("Input Required", "Enter a new topping.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Topping already exists.", "Duplicate Topping", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonDeleteTopping_Click(object sender, EventArgs e)
        {
            if (listBoxToppings.SelectedItem != null)
            {
                string toppingToRemove = listBoxToppings.SelectedItem.ToString();
                if (MessageBox.Show($"Are you sure you want to delete '{toppingToRemove}'?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    availableToppings.Remove(toppingToRemove);

                    // Refresh list
                    LoadToppingsToListBox();
                    LoadToppingsToCheckedListBox();

                    // Remove the topping from any pizzas that have it
                    foreach (var pizza in pizzas)
                    {
                        pizza.Toppings.RemoveAll(t => t == toppingToRemove);
                    }
                    // Refresh pizza list
                    LoadPizzasToDataGridView(); 
                }
            }
            else
            {
                MessageBox.Show("Select a topping to delete.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonEditTopping_Click(object sender, EventArgs e)
        {
            if (listBoxToppings.SelectedItem != null)
            {
                string oldTopping = listBoxToppings.SelectedItem.ToString();
                string newTopping = textBoxNewTopping.Text.Trim();

                if (!string.IsNullOrEmpty(newTopping) && newTopping != oldTopping)
                {
                    if (availableToppings.Contains(newTopping))
                    {
                        MessageBox.Show("Topping already exists.", "Duplicate Topping", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    int index = availableToppings.IndexOf(oldTopping);

                    // Update topping in the list
                    availableToppings[index] = newTopping;

                    // Sort toppings alphabetically
                    availableToppings.Sort();

                    // Refresh list
                    LoadToppingsToListBox();
                    LoadToppingsToCheckedListBox();

                    // Update the topping in pizzas as well
                    foreach (var pizza in pizzas)
                    {
                        for (int i = 0; i < pizza.Toppings.Count; i++)
                        {
                            if (pizza.Toppings[i] == oldTopping)
                            {
                                pizza.Toppings[i] = newTopping;
                            }
                        }
                    }
                    // Refresh pizza list
                    LoadPizzasToDataGridView(); 


                    textBoxNewTopping.Clear();
                    // Re-enable "Add"
                    buttonAddTopping.Enabled = true;

                    // Disable "Edit"
                    buttonEditTopping.Enabled = false; 

                    // Deselect
                    listBoxToppings.ClearSelected();
                }
                else if (string.IsNullOrEmpty(newTopping))
                {
                    MessageBox.Show("Please enter a new topping name.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (newTopping == oldTopping)
                {
                    MessageBox.Show("Please enter a different topping name to edit.", "No Change", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Please select a topping to edit.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void listBoxToppings_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxToppings.SelectedItem != null)
            {
                textBoxNewTopping.Text = listBoxToppings.SelectedItem.ToString();

                // Disable add button while editing and enable edit button
                buttonAddTopping.Enabled = false;
                buttonEditTopping.Enabled = true; 
            }
            else
            {
                textBoxNewTopping.Clear();

                // Since nothing selected, enable add button and disable edit button
                buttonAddTopping.Enabled = true;
                buttonEditTopping.Enabled = false; 
            }
        }

        private void buttonAddPizza_Click(object sender, EventArgs e)
        {
            string pizzaName = textBoxPizzaName.Text.Trim();
            if (string.IsNullOrEmpty(pizzaName))
            {
                MessageBox.Show("Please enter a pizza name.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            // Check if pizza name already exists
            if (pizzas.Any(p => p.Name.ToLower() == pizzaName.ToLower())) 
            {
                MessageBox.Show("Pizza with this name already exists.", "Duplicate Pizza Name", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Pizza newPizza = new Pizza(pizzaName);
            foreach (var item in checkedListBoxPizzaToppings.CheckedItems)
            {
                newPizza.Toppings.Add(item.ToString());
            }
            pizzas.Add(newPizza);
            LoadPizzasToDataGridView();
            ClearPizzaInputFields();
        }
        //Method to uncheck all items
        private void ClearPizzaInputFields()
        {
            textBoxPizzaName.Clear();
            for (int i = 0; i < checkedListBoxPizzaToppings.Items.Count; i++)
            {
                checkedListBoxPizzaToppings.SetItemChecked(i, false);
            }
        }

        private void dataGridViewPizzas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonEditPizza_Click(object sender, EventArgs e)
        {
            if (dataGridViewPizzas.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridViewPizzas.SelectedRows[0];
                string oldPizzaName = selectedRow.Cells["PizzaNameColumn"].Value?.ToString();

                if (!string.IsNullOrEmpty(oldPizzaName))
                {
                    Pizza pizzaToEdit = pizzas.Find(p => p.Name == oldPizzaName);
                    if (pizzaToEdit != null)
                    {
                        string newPizzaName = textBoxPizzaName.Text.Trim();
                        if (string.IsNullOrEmpty(newPizzaName))
                        {
                            MessageBox.Show("Please enter a pizza name.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        if (newPizzaName != oldPizzaName && pizzas.Any(p => p.Name.ToLower() == newPizzaName.ToLower()))
                        {
                            MessageBox.Show("Pizza with this name already exists.", "Duplicate Pizza Name", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        pizzaToEdit.Name = newPizzaName;

                        // Clear old toppings
                        pizzaToEdit.Toppings.Clear(); 
                        foreach (var item in checkedListBoxPizzaToppings.CheckedItems)
                        {
                            pizzaToEdit.Toppings.Add(item.ToString());
                        }

                        // Refresh
                        LoadPizzasToDataGridView(); 
                        ClearPizzaInputFields();

                        // Deselect row
                        dataGridViewPizzas.ClearSelection(); 

                        buttonAddPizza.Enabled = true;
                        buttonEditPizza.Enabled = false;
                        buttonDeletePizza.Enabled = false;
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a pizza to edit.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonDeletePizza_Click(object sender, EventArgs e)
        {
            if (dataGridViewPizzas.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridViewPizzas.SelectedRows[0];
                string pizzaNameToDelete = selectedRow.Cells["PizzaNameColumn"].Value?.ToString();

                if (!string.IsNullOrEmpty(pizzaNameToDelete))
                {
                    if (MessageBox.Show($"Are you sure you want to delete '{pizzaNameToDelete}'?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        pizzas.RemoveAll(p => p.Name == pizzaNameToDelete);
                        LoadPizzasToDataGridView();
                        ClearPizzaInputFields();
                        dataGridViewPizzas.ClearSelection();
                        buttonAddPizza.Enabled = true;
                        buttonEditPizza.Enabled = false;
                        buttonDeletePizza.Enabled = false;
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a pizza to delete.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxPizzaName_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridViewPizzas_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewPizzas.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridViewPizzas.SelectedRows[0];
                if (selectedRow != null)
                {
                    string pizzaName = selectedRow.Cells["PizzaNameColumn"].Value?.ToString();
                    string toppingsString = selectedRow.Cells["PizzaToppingsColumn"].Value?.ToString();

                    if (!string.IsNullOrEmpty(pizzaName))
                    {
                        textBoxPizzaName.Text = pizzaName;

                        // Uncheck all and re-check based on pizza toppings
                        for (int i = 0; i < checkedListBoxPizzaToppings.Items.Count; i++)
                        {
                            checkedListBoxPizzaToppings.SetItemChecked(i, false); 
                            string topping = checkedListBoxPizzaToppings.Items[i].ToString();
                            if (!string.IsNullOrEmpty(toppingsString) && toppingsString.Split(',').Select(s => s.Trim()).Contains(topping))
                            {
                                // Re-check
                                checkedListBoxPizzaToppings.SetItemChecked(i, true); 
                            }
                        }

                        buttonAddPizza.Enabled = true;
                        buttonEditPizza.Enabled = true;
                        buttonDeletePizza.Enabled = true;
                    }
                }
            }
            else
            {
                ClearPizzaInputFields();
                buttonAddPizza.Enabled = true;
                buttonEditPizza.Enabled = false;
                buttonDeletePizza.Enabled = false;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
