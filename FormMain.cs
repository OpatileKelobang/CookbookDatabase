using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace CookbookDatabase
{
    public partial class FormMain : Form
    {
        SqlConnection connection;
        string connectionString;

        public FormMain()
        {
            InitializeComponent();
            connectionString = ConfigurationManager
                .ConnectionStrings["CookbookDatabase.Properties.Settings.CookbookConnectionString"]
                .ConnectionString;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            PopulateRecipes();
            PopulateAllIngredients();
        }

        private void PopulateRecipes()
        {
            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Recipe", connection))
            {
                DataTable recipeTable = new DataTable();
                adapter.Fill(recipeTable);

                lstRecipes.DisplayMember = "Name";
                lstRecipes.ValueMember = "Id";
                lstRecipes.DataSource = recipeTable;
            }
            
        }

        private void PopulateAllIngredients()
        {
            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Ingridient", connection))
            {
                DataTable ingridientTable = new DataTable();
                adapter.Fill(ingridientTable);

                lstAllIngredients.DisplayMember = "Name";
                lstAllIngredients.ValueMember = "Id";
                lstAllIngredients.DataSource = ingridientTable;
            }

        }

        private void PopulateIngrideints()
        {
            string query = "SELECT a.Name FROM Ingridient a " +
                           "INNER JOIN RecipeIngeredient b ON a.Id = b.IngredientID " +
                           "WHERE b.RecipeID = @RecipeID";

            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                command.Parameters.AddWithValue("@RecipeID", lstRecipes.SelectedValue);

                DataTable ingridientTable = new DataTable();
                adapter.Fill(ingridientTable);

                lstIngredients.DisplayMember = "Name";
                lstIngredients.ValueMember = "Id";
                lstIngredients.DataSource = ingridientTable;
            }

        }

        private void lstRecipes_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulateIngrideints();
        }

        private void btnAddRecipe_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO Recipe VALUES (@RecipeName, 80, 'Another fucking salad!')";

            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@RecipeName", txtRecipeName.Text);
                command.ExecuteNonQuery();
            }

            PopulateRecipes();
        }

        private void btnUpdateRecipeName_Click(object sender, EventArgs e)
        {
            string query = "UPDATE Recipe SET Name = @RecipeName WHERE Id = @RecipeID";

            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@RecipeName", txtRecipeName.Text);
                command.Parameters.AddWithValue("@RecipeID", lstRecipes.SelectedValue);
                command.ExecuteNonQuery();
            }

            PopulateRecipes();
        }

        private void btnAddToRecipe_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO RecipeIngeredient VALUES (@RecipeID, @IngredientID)";

            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@RecipeID", lstRecipes.SelectedValue);
                command.Parameters.AddWithValue("@IngredientID", lstAllIngredients.SelectedValue);
                command.ExecuteNonQuery();
            }

            PopulateRecipes();
        }
    }
}
