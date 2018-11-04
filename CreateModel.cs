using ContactManager.Data;
using ContactManager.Pages.Contacts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;

public class CreateModel : DI_BasePageModel
{
    public CreateModel(
        ApplicationDbContext context,
        IAuthorizationService authorizationService,
        UserManager<IdentityUser> userManager)
        : base(context, authorizationService, userManager)
    {
    }
}