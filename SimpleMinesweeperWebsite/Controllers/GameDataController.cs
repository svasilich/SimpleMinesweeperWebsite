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
            string filePath = Path.Combine(appEnvironment.WebRootPath, "Install/SimpleMinesweeperSetup.msi");
            string fileType = "application/x-ole-storage";
            string fileName = "SimpleMinesweeperSetup.msi";
            return PhysicalFile(filePath, fileType, fileName);
        }

        public IActionResult LastVersion()
        {
            string versionPath = Path.Combine(appEnvironment.WebRootPath, "Install/lastVersion.json");
            string versionString = System.IO.File.ReadAllText(versionPath);
            Version version = JsonConvert.DeserializeObject<Version>(versionString);
            return Json(version);
        }
    }
}