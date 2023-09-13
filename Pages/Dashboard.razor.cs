using Microsoft.AspNetCore.Components;
using SparkDotnet8.Application.Models;
using SparkDotnet8.Pages.Shared;

namespace SparkDotnet8.Pages;

public partial class Dashboard
{
    [CascadingParameter]
    public MainLayout? Layout { get; set; }
    private User? user => Layout.User;
}
