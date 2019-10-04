using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Net.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace SimpleMinesweeperWebsite.Controllers
{
    public class GameDataController : Controller
    {
        private readonly IHostingEnvironment appEnvironment;
        public GameDataController(IHostingEnvironment environment)
        {
            appEnvironment = environment;
        }

        public IActionResult GetInstaller()
        {
            string file_path = Path.Combine(appEnvironment.WebRootPath, "Install/SimpleMinesweeperSetup.msi");
            string file_type = "application/x-ole-storage";
            string file_name = "SimpleMinesweeperSetup.msi";
            return PhysicalFile(file_path, file_type, file_name);
        }

        public IActionResult LastVersion()
        {
            Version version = new Version(1, 0, 0, 1);
            return Json(version);
        }
    }
}