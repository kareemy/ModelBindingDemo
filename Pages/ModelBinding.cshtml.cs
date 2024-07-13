using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ModelBindingDemo.Pages;

public class ModelBindingModel : PageModel
{
    private readonly ILogger<ModelBindingModel> _logger;

    [BindProperty]
    [Display(Name = "User Name")]
    [StringLength(60, MinimumLength = 3)]
    [Required]
    public string Username {get; set;} = string.Empty;

    [BindProperty]
    [StringLength(60, MinimumLength = 8)]
    [Required]
    public string Password {get; set;} = string.Empty;

    public ModelBindingModel(ILogger<ModelBindingModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {

    }

    public void OnPost()
    {
        _logger.LogWarning($"OnPost Called. User name = {Username} Password = {Password}");
    }
}