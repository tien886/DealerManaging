
namespace DealerManaging;
using DealerManaging.Models;
public partial class AddDealer : ContentPage
{
    public DaiLy currentDealer { get; set; } = new DaiLy(); 
	public AddDealer()
	{
		InitializeComponent();
	}

    private void btnAdd_Clicked(object sender, EventArgs e)
    {
        
    }

    private void btnReset_Clicked(object sender, EventArgs e)
    {
        currentDealer = new DaiLy();
        BindingContext = currentDealer;
    }

    private void btnOut_Clicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("..");  
    }
}