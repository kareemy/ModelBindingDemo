using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Eventing.Reader;
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
    [StringLength(60, MinimumLength = 8, ErrorMessage = "Your password must be at least 8 characters.")]
    [Required]
    public string Password {get; set;} = string.Empty;

    [BindProperty]
    public int LoginRole {get; set;}
    
    [BindProperty]
    public bool RememberMe {get; set;}

    public ModelBindingModel(ILogger<ModelBindingModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {

    }

    public void OnPost()
    {
        _logger.LogWarning($"OnPost Called. User name = {Username} Password = {Password} Login Role = {LoginRole} Remember Me = {RememberMe}");
    }
}