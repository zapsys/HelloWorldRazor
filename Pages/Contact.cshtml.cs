using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HelloWorldRazor.Pages
{
    public class ContactModel : PageModel
    {
        public string Message { get; private set; } = string.Empty;

        public void OnPost(string name, string email)
        {
            Message = $"Thank you, {name}! We have received your email.";
        }
    }
}