using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO; //處理檔案必須引用System.IO命名空間

namespace prjFileUpLoad_Multiple.Controllers
{
    public class FileUploadController : Controller
    {
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(HttpPostedFileBase photo)
        {
            string fileName = "";

            if(photo != null)
            {
                if(photo.ContentLength > 0)
                {
                    //取得檔案名稱
                    fileName = Path.GetFileName(photo.FileName);
                    var path = Path.Combine(Server.MapPath("~/Photos"), fileName);
                    photo.SaveAs(path);
                }
            }

            return RedirectToAction("ShowPhotos");
        }

        public string ShowPhotos()
        {
            string show = "";
            int n = 0;

            //建立可操作Photos資料夾的dir物件
            DirectoryInfo dir = new DirectoryInfo(Server.MapPath("~/Photos"));

            FileInfo[] fInfo = dir.GetFiles();

            foreach (FileInfo result in fInfo)
            {
                n++;

                show += "<a href='../Photos/" + result.Name +
                        "' target='_blank'><img src='../Photos/" + result.Name +
                        "' width='90' height='60' border='0'></a> ";

                if (n % 4 == 0)
                {
                    show += "<p>";
                }
            }

            show += "<p><a href='Create'>返回</a></p>";
            return show;
        }
    }
}