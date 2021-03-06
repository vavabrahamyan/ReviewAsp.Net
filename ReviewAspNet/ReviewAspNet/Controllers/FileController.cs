﻿using System.IO;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Web.Mvc;

namespace ReviewAspNet.Controllers
{
    public class FileController:Controller
    {
        public string GetData()
        {
            string id = HttpContext.Request.Cookies["id"].Value;
            return id.ToString();
        }
        // downloading file
        public FilePathResult GetFile()
        {
            string filePath = Server.MapPath(@"~\Files\Vahe's Resume.pdf");

            string fileType = "Application/octet-stream";

            string fileName = "Vahe's Resume.pdf";

            return File(filePath, fileType, fileName);
        }
        //downloading file + read bytes
        public FileContentResult GetBytes()
        {
            string filePath = Server.MapPath(@"~\Files\Vahe's Resume.pdf");

            byte[] arr = System.IO.File.ReadAllBytes(filePath);

            string fileType = "Application/octet-stream";

            string fileName = "Vahe's Resume.pdf";

            return File(arr, fileType, fileName);
        }
        //downloading file + creating stream
        public FileStreamResult GetStream()
        {
            string filePath = Server.MapPath(@"~\Files\Vahe's Resume.pdf");

            FileStream fs = new FileStream(filePath, FileMode.Open);

            string fileType = "Application/octet-stream";

            string fileName = "Vahe's Resume.pdf";

            return File(fs, fileType, fileName);
        }
    }
}