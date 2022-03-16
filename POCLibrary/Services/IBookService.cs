using Microsoft.AspNetCore.Mvc;
using POCLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POCLibrary.Services
{
    public interface IBookService
    {
        public Task<IEnumerable<Books>> FindBooksByTermAsync(string term);
    }
}
