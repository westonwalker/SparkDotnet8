using Microsoft.AspNetCore.Components;
using SparkDotnet8.Application.Models;

namespace SparkDotnet8.Pages.Shared;

public partial class NavMenu
{
    [CascadingParameter]
    public MainLayout? Layout { get; set; }
    private User? user => Layout?.User;
}
