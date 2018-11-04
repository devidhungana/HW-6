using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Threading.Tasks;

namespace ContactManager.Pages
{
    public class ContactModel : PageModel
    {
        public string Message { get; set; }

        public void OnGet()
        {
            Message = "Your contact page.";
        }
    }

    public async Task<IActionResult> OnPostAsync()
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }

        Contact.OwnerID = UserManager.GetUserId(User);

        // requires using ContactManager.Authorization;
        var isAuthorized = await AuthorizationService.AuthorizeAsync(
                                                    User, Contact,
                                                    ContactOperations.Create);
        if (!isAuthorized.Succeeded)
        {
            return new ChallengeResult();
        }

        Context.Contact.Add(Contact);
        await Context.SaveChangesAsync();

        return RedirectToPage("./Index");
    }
}