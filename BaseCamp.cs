
namespace basecamp;

public partial class BaseCamp : Form
{
    public BaseCamp()
    {
        InitializeComponent();

        // Add buttons
        CustomButton budgetButton = new()
        {
            Text = "Budget",
            Width = 300,
            Height = 100,
            Left = 100,
            Top = 50
        };

        CustomButton toDoButton = new()
        {
            Text = "To Do",
            Width = 300,
            Height = 100,
            Left = 100,
            Top = 200
        };

        CustomButton extraButton = new()
        {
            Text = "Extra",
            Width = 300,
            Height = 100,
            Left = 100,
            Top = 350
        };

        this.Controls.Add(budgetButton);
        this.Controls.Add(toDoButton);
        this.Controls.Add(extraButton);
    }

    private void BaseCamp_Load(object sender, EventArgs e)
    {

    }
}

public class CustomButton : Button
{
    public CustomButton()
    {
        this.BackColor = ColorTranslator.FromHtml("#ff99aa");
        this.ForeColor = ColorTranslator.FromHtml("#881122");
        this.Font = new Font("Arial", 14, FontStyle.Bold);
        this.FlatStyle = FlatStyle.Flat;
    }
}

// public class BudgetForm : Form
// {
//     public BudgetForm()
//     {
//         InitializeComponent()
//     }
// }