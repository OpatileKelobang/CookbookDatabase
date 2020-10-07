namespace CookbookDatabase
{
    partial class FormMain
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
            this.cookbookDataSet = new CookbookDatabase.CookbookDataSet();
            this.lblRecipes = new System.Windows.Forms.Label();
            this.lstRecipes = new System.Windows.Forms.ListBox();
            this.lblIngridients = new System.Windows.Forms.Label();
            this.lstIngredients = new System.Windows.Forms.ListBox();
            this.btnAddRecipe = new System.Windows.Forms.Button();
            this.txtRecipeName = new System.Windows.Forms.TextBox();
            this.btnUpdateRecipeName = new System.Windows.Forms.Button();
            this.lstAllIngredients = new System.Windows.Forms.ListBox();
            this.lblAllIngredients = new System.Windows.Forms.Label();
            this.btnAddToRecipe = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.cookbookDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // cookbookDataSet
            // 
            this.cookbookDataSet.DataSetName = "CookbookDataSet";
            this.cookbookDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblRecipes
            // 
            this.lblRecipes.AutoSize = true;
            this.lblRecipes.Location = new System.Drawing.Point(33, 152);
            this.lblRecipes.Name = "lblRecipes";
            this.lblRecipes.Size = new System.Drawing.Size(46, 13);
            this.lblRecipes.TabIndex = 0;
            this.lblRecipes.Text = "Recipes";
            // 
            // lstRecipes
            // 
            this.lstRecipes.FormattingEnabled = true;
            this.lstRecipes.Location = new System.Drawing.Point(36, 168);
            this.lstRecipes.Name = "lstRecipes";
            this.lstRecipes.Size = new System.Drawing.Size(120, 251);
            this.lstRecipes.TabIndex = 1;
            this.lstRecipes.SelectedIndexChanged += new System.EventHandler(this.lstRecipes_SelectedIndexChanged);
            // 
            // lblIngridients
            // 
            this.lblIngridients.AutoSize = true;
            this.lblIngridients.Location = new System.Drawing.Point(243, 152);
            this.lblIngridients.Name = "lblIngridients";
            this.lblIngridients.Size = new System.Drawing.Size(92, 13);
            this.lblIngridients.TabIndex = 2;
            this.lblIngridients.Text = "Recipe Ingridients";
            // 
            // lstIngredients
            // 
            this.lstIngredients.FormattingEnabled = true;
            this.lstIngredients.Location = new System.Drawing.Point(246, 169);
            this.lstIngredients.Name = "lstIngredients";
            this.lstIngredients.Size = new System.Drawing.Size(120, 251);
            this.lstIngredients.TabIndex = 3;
            // 
            // btnAddRecipe
            // 
            this.btnAddRecipe.Location = new System.Drawing.Point(78, 89);
            this.btnAddRecipe.Name = "btnAddRecipe";
            this.btnAddRecipe.Size = new System.Drawing.Size(78, 29);
            this.btnAddRecipe.TabIndex = 4;
            this.btnAddRecipe.Text = "Add Recipe";
            this.btnAddRecipe.UseVisualStyleBackColor = true;
            this.btnAddRecipe.Click += new System.EventHandler(this.btnAddRecipe_Click);
            // 
            // txtRecipeName
            // 
            this.txtRecipeName.Location = new System.Drawing.Point(56, 49);
            this.txtRecipeName.Name = "txtRecipeName";
            this.txtRecipeName.Size = new System.Drawing.Size(100, 20);
            this.txtRecipeName.TabIndex = 5;
            // 
            // btnUpdateRecipeName
            // 
            this.btnUpdateRecipeName.Location = new System.Drawing.Point(258, 89);
            this.btnUpdateRecipeName.Name = "btnUpdateRecipeName";
            this.btnUpdateRecipeName.Size = new System.Drawing.Size(108, 29);
            this.btnUpdateRecipeName.TabIndex = 6;
            this.btnUpdateRecipeName.Text = "Update Name";
            this.btnUpdateRecipeName.UseVisualStyleBackColor = true;
            this.btnUpdateRecipeName.Click += new System.EventHandler(this.btnUpdateRecipeName_Click);
            // 
            // lstAllIngredients
            // 
            this.lstAllIngredients.FormattingEnabled = true;
            this.lstAllIngredients.Location = new System.Drawing.Point(472, 169);
            this.lstAllIngredients.Name = "lstAllIngredients";
            this.lstAllIngredients.Size = new System.Drawing.Size(120, 251);
            this.lstAllIngredients.TabIndex = 8;
            // 
            // lblAllIngredients
            // 
            this.lblAllIngredients.AutoSize = true;
            this.lblAllIngredients.Location = new System.Drawing.Point(469, 152);
            this.lblAllIngredients.Name = "lblAllIngredients";
            this.lblAllIngredients.Size = new System.Drawing.Size(69, 13);
            this.lblAllIngredients.TabIndex = 7;
            this.lblAllIngredients.Text = "All Ingridients";
            // 
            // btnAddToRecipe
            // 
            this.btnAddToRecipe.Location = new System.Drawing.Point(472, 89);
            this.btnAddToRecipe.Name = "btnAddToRecipe";
            this.btnAddToRecipe.Size = new System.Drawing.Size(120, 29);
            this.btnAddToRecipe.TabIndex = 9;
            this.btnAddToRecipe.Text = "Add To Recipe";
            this.btnAddToRecipe.UseVisualStyleBackColor = true;
            this.btnAddToRecipe.Click += new System.EventHandler(this.btnAddToRecipe_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAddToRecipe);
            this.Controls.Add(this.lstAllIngredients);
            this.Controls.Add(this.lblAllIngredients);
            this.Controls.Add(this.btnUpdateRecipeName);
            this.Controls.Add(this.txtRecipeName);
            this.Controls.Add(this.btnAddRecipe);
            this.Controls.Add(this.lstIngredients);
            this.Controls.Add(this.lblIngridients);
            this.Controls.Add(this.lstRecipes);
            this.Controls.Add(this.lblRecipes);
            this.Name = "FormMain";
            this.Text = "Cookbook";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cookbookDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CookbookDataSet cookbookDataSet;
        private System.Windows.Forms.Label lblRecipes;
        private System.Windows.Forms.ListBox lstRecipes;
        private System.Windows.Forms.Label lblIngridients;
        private System.Windows.Forms.ListBox lstIngredients;
        private System.Windows.Forms.Button btnAddRecipe;
        private System.Windows.Forms.TextBox txtRecipeName;
        private System.Windows.Forms.Button btnUpdateRecipeName;
        private System.Windows.Forms.ListBox lstAllIngredients;
        private System.Windows.Forms.Label lblAllIngredients;
        private System.Windows.Forms.Button btnAddToRecipe;
    }
}

