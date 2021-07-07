using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ContactManagement.Data;
using ContactManagement.Models;

namespace ContactManagement.Pages.Contacts
{
    public class CreateModel : PageModel
    {
        private readonly ContactManagement.Data.ContactContext _context;

        public CreateModel(ContactManagement.Data.ContactContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Contact Contact { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Contact.Add(Contact);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
