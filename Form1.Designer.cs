namespace PizzaApp2
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
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxToppings = new System.Windows.Forms.ListBox();
            this.textBoxNewTopping = new System.Windows.Forms.TextBox();
            this.buttonDeleteTopping = new System.Windows.Forms.Button();
            this.buttonAddTopping = new System.Windows.Forms.Button();
            this.buttonEditTopping = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewPizzas = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxPizzaName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.checkedListBoxPizzaToppings = new System.Windows.Forms.CheckedListBox();
            this.buttonAddPizza = new System.Windows.Forms.Button();
            this.buttonEditPizza = new System.Windows.Forms.Button();
            this.buttonDeletePizza = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPizzas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(777, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Topping Managment Section";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // listBoxToppings
            // 
            this.listBoxToppings.FormattingEnabled = true;
            this.listBoxToppings.ItemHeight = 15;
            this.listBoxToppings.Location = new System.Drawing.Point(721, 45);
            this.listBoxToppings.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.listBoxToppings.Name = "listBoxToppings";
            this.listBoxToppings.Size = new System.Drawing.Size(361, 244);
            this.listBoxToppings.TabIndex = 1;
            this.listBoxToppings.SelectedIndexChanged += new System.EventHandler(this.listBoxToppings_SelectedIndexChanged);
            // 
            // textBoxNewTopping
            // 
            this.textBoxNewTopping.Location = new System.Drawing.Point(848, 330);
            this.textBoxNewTopping.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxNewTopping.Name = "textBoxNewTopping";
            this.textBoxNewTopping.Size = new System.Drawing.Size(132, 23);
            this.textBoxNewTopping.TabIndex = 2;
            // 
            // buttonDeleteTopping
            // 
            this.buttonDeleteTopping.Location = new System.Drawing.Point(1090, 124);
            this.buttonDeleteTopping.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonDeleteTopping.Name = "buttonDeleteTopping";
            this.buttonDeleteTopping.Size = new System.Drawing.Size(100, 27);
            this.buttonDeleteTopping.TabIndex = 3;
            this.buttonDeleteTopping.Text = "Delete Topping";
            this.buttonDeleteTopping.UseVisualStyleBackColor = true;
            this.buttonDeleteTopping.Click += new System.EventHandler(this.buttonDeleteTopping_Click);
            // 
            // buttonAddTopping
            // 
            this.buttonAddTopping.Location = new System.Drawing.Point(988, 330);
            this.buttonAddTopping.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonAddTopping.Name = "buttonAddTopping";
            this.buttonAddTopping.Size = new System.Drawing.Size(191, 27);
            this.buttonAddTopping.TabIndex = 4;
            this.buttonAddTopping.Text = "Add Topping";
            this.buttonAddTopping.UseVisualStyleBackColor = true;
            this.buttonAddTopping.Click += new System.EventHandler(this.buttonAddTopping_Click);
            // 
            // buttonEditTopping
            // 
            this.buttonEditTopping.Location = new System.Drawing.Point(1090, 69);
            this.buttonEditTopping.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonEditTopping.Name = "buttonEditTopping";
            this.buttonEditTopping.Size = new System.Drawing.Size(100, 27);
            this.buttonEditTopping.TabIndex = 5;
            this.buttonEditTopping.Text = "Edit Topping";
            this.buttonEditTopping.UseVisualStyleBackColor = true;
            this.buttonEditTopping.Click += new System.EventHandler(this.buttonEditTopping_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(-4, 27);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Existing Pizzas";
            // 
            // dataGridViewPizzas
            // 
            this.dataGridViewPizzas.AllowUserToResizeRows = false;
            this.dataGridViewPizzas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewPizzas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewPizzas.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dataGridViewPizzas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPizzas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewPizzas.Location = new System.Drawing.Point(0, 45);
            this.dataGridViewPizzas.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridViewPizzas.MultiSelect = false;
            this.dataGridViewPizzas.Name = "dataGridViewPizzas";
            this.dataGridViewPizzas.ReadOnly = true;
            this.dataGridViewPizzas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPizzas.Size = new System.Drawing.Size(516, 294);
            this.dataGridViewPizzas.StandardTab = true;
            this.dataGridViewPizzas.TabIndex = 7;
            this.dataGridViewPizzas.SelectionChanged += new System.EventHandler(this.dataGridViewPizzas_SelectionChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-1, 568);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "New Pizza Name";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBoxPizzaName
            // 
            this.textBoxPizzaName.Location = new System.Drawing.Point(113, 565);
            this.textBoxPizzaName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxPizzaName.Name = "textBoxPizzaName";
            this.textBoxPizzaName.Size = new System.Drawing.Size(132, 23);
            this.textBoxPizzaName.TabIndex = 9;
            this.textBoxPizzaName.TextChanged += new System.EventHandler(this.textBoxPizzaName_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(730, 330);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Add New Topping";
            // 
            // checkedListBoxPizzaToppings
            // 
            this.checkedListBoxPizzaToppings.CheckOnClick = true;
            this.checkedListBoxPizzaToppings.FormattingEnabled = true;
            this.checkedListBoxPizzaToppings.Location = new System.Drawing.Point(0, 381);
            this.checkedListBoxPizzaToppings.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.checkedListBoxPizzaToppings.Name = "checkedListBoxPizzaToppings";
            this.checkedListBoxPizzaToppings.Size = new System.Drawing.Size(285, 166);
            this.checkedListBoxPizzaToppings.TabIndex = 11;
            // 
            // buttonAddPizza
            // 
            this.buttonAddPizza.Location = new System.Drawing.Point(253, 565);
            this.buttonAddPizza.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonAddPizza.Name = "buttonAddPizza";
            this.buttonAddPizza.Size = new System.Drawing.Size(100, 27);
            this.buttonAddPizza.TabIndex = 12;
            this.buttonAddPizza.Text = "Add Pizza";
            this.buttonAddPizza.UseVisualStyleBackColor = true;
            this.buttonAddPizza.Click += new System.EventHandler(this.buttonAddPizza_Click);
            // 
            // buttonEditPizza
            // 
            this.buttonEditPizza.Location = new System.Drawing.Point(524, 69);
            this.buttonEditPizza.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonEditPizza.Name = "buttonEditPizza";
            this.buttonEditPizza.Size = new System.Drawing.Size(100, 27);
            this.buttonEditPizza.TabIndex = 13;
            this.buttonEditPizza.Text = "Edit Pizza";
            this.buttonEditPizza.UseVisualStyleBackColor = true;
            this.buttonEditPizza.Click += new System.EventHandler(this.buttonEditPizza_Click);
            // 
            // buttonDeletePizza
            // 
            this.buttonDeletePizza.Location = new System.Drawing.Point(524, 114);
            this.buttonDeletePizza.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonDeletePizza.Name = "buttonDeletePizza";
            this.buttonDeletePizza.Size = new System.Drawing.Size(100, 27);
            this.buttonDeletePizza.TabIndex = 14;
            this.buttonDeletePizza.Text = "Delete Pizza";
            this.buttonDeletePizza.UseVisualStyleBackColor = true;
            this.buttonDeletePizza.Click += new System.EventHandler(this.buttonDeletePizza_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(119, 10);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(212, 19);
            this.label5.TabIndex = 15;
            this.label5.Text = "Pizza Management Section";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(101, 359);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 15);
            this.label6.TabIndex = 16;
            this.label6.Text = "Create A New Pizza";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1204, 657);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonDeletePizza);
            this.Controls.Add(this.buttonEditPizza);
            this.Controls.Add(this.buttonAddPizza);
            this.Controls.Add(this.checkedListBoxPizzaToppings);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxPizzaName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridViewPizzas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonEditTopping);
            this.Controls.Add(this.buttonAddTopping);
            this.Controls.Add(this.buttonDeleteTopping);
            this.Controls.Add(this.textBoxNewTopping);
            this.Controls.Add(this.listBoxToppings);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPizzas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxToppings;
        private System.Windows.Forms.TextBox textBoxNewTopping;
        private System.Windows.Forms.Button buttonDeleteTopping;
        private System.Windows.Forms.Button buttonAddTopping;
        private System.Windows.Forms.Button buttonEditTopping;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewPizzas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxPizzaName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckedListBox checkedListBoxPizzaToppings;
        private System.Windows.Forms.Button buttonAddPizza;
        private System.Windows.Forms.Button buttonEditPizza;
        private System.Windows.Forms.Button buttonDeletePizza;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

