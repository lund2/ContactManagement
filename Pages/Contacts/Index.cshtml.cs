using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ContactManagement.Data;
using ContactManagement.Models;

namespace ContactManagement.Pages.Contacts
{
    public class IndexModel : PageModel
    {
        private readonly ContactManagement.Data.ContactContext _context;

        public IndexModel(ContactManagement.Data.ContactContext context)
        {
            _context = context;
        }

        public IList<Contact> Contact { get;set; }

        public async Task OnGetAsync()
        {
            Contact = await _context.Contact.ToListAsync();
        }
    }
}
