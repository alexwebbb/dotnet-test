using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.FileProviders;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ReduxDotNet.Controllers
{

    public class FileController : Controller
    {
        private readonly IFileProvider _fileProvider;

        public FileController(IFileProvider fileProvider)
        {
            _fileProvider = fileProvider;
        }

        public IActionResult Index()
        {
            var contents = _fileProvider.GetDirectoryContents("");
            return View(contents);
        }
    }
}
