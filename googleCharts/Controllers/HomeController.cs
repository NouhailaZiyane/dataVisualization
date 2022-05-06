using googleCharts.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace googleCharts.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        private DataContext db = new DataContext();
        
        public ActionResult GetChartData()
        {
            var niv1 = db.cgeo.Where(x => x.niveau == 1).Count();
            var niv2 = db.cgeo.Where(x => x.niveau == 2).Count();
            var niv3 = db.cgeo.Where(x => x.niveau == 3).Count();
            var niv4 = db.cgeo.Where(x => x.niveau == 4).Count();
            var niv5 = db.cgeo.Where(x => x.niveau == 5).Count();

            ratio3 obj = new ratio3();
            obj.niv1 = niv1;
            obj.niv2 = niv2;
            obj.niv3 = niv3;
            obj.niv4 = niv4;
            obj.niv5 = niv5;
            return Json(obj,JsonRequestBehavior.AllowGet);
        }
        public ActionResult GetChart()
        {

            int m1 = db.tablette.Where(x => x.modele == "Samsung Tab 4").Count();
            int m2 = db.tablette.Where(x => x.modele != "Samsung Tab 4").Count();

            ratio1 obj = new ratio1();
            obj.m1 = m1;
            obj.m2 = m2;

            return Json(obj, JsonRequestBehavior.AllowGet);
        }
        public ActionResult Getpos()
        {

            int enqueteurs = db.profil.Where(x => x.role == 0).Count();
            int superviseurs_centrale = db.profil.Where(x => x.role == 1).Count();
            int superviseurs_regionale = db.profil.Where(x => x.role == 2).Count();
            int informaticiens = db.profil.Where(x => x.role == 3).Count();


            ratio2 obj = new ratio2();
            obj.enqueteurs = enqueteurs;
            obj.superviseurs_centrale = superviseurs_centrale;
            obj.superviseurs_regionale = superviseurs_regionale;
            obj.informaticiens = informaticiens;

            return Json(obj, JsonRequestBehavior.AllowGet);
        }
        public ActionResult Gettab()
        {

            int an17 = db.prog.Where(x => x.annee == 2017).Count();
            int an18 = db.prog.Where(x => x.annee == 2018).Count();
            int an19 = db.prog.Where(x => x.annee == 2019).Count();
            int an20 = db.prog.Where(x => x.annee == 2020).Count();


            ratio4 obj = new ratio4();
            obj.an17 = an17;
            obj.an18 = an18;
            obj.an19 = an19;
            obj.an20 = an20;

            return Json(obj, JsonRequestBehavior.AllowGet);
        }
        public ActionResult GetData()
        {
            int m1 = db.c3.Where(x => x.men == 1).Where(x => x.nbr !=0).Count()*2;
            int m4 = db.c3.Where(x => x.men == 4).Where(x => x.nbr != 0).Count()*2;
            int m2 = db.c3.Where(x => x.men == 2).Where(x => x.nbr != 0).Count()*2;
            int m3 = db.c3.Where(x => x.men == 3).Where(x => x.nbr != 0).Count()*2;
            int m5 = db.c3.Where(x => x.men ==5).Where(x => x.nbr != 0).Count()*2;
            int m6 = db.c3.Where(x => x.men == 6).Where(x => x.nbr != 0).Count()*2;
            int m7 = db.c3.Where(x => x.men == 7).Where(x => x.nbr != 0).Count()*2;
            int m8 = db.c3.Where(x => x.men == 8).Where(x => x.nbr != 0).Count()*2;
            int m9 = db.c3.Where(x => x.men == 9).Where(x => x.nbr != 0).Count()*2;
            int m10 = db.c3.Where(x => x.men == 10).Where(x => x.nbr != 0).Count()*2;
            int m11 = db.c3.Where(x => x.men == 11).Where(x => x.nbr != 0).Count()*2;
            int m12 = db.c3.Where(x => x.men == 12).Where(x => x.nbr != 0).Count()*2;
            int m13 = db.c3.Where(x => x.men == 12).Where(x => x.nbr != 0).Count()*2;
            int m14 = db.c3.Where(x => x.men == 14).Where(x => x.nbr != 0).Count()*2;
            int m15 = db.c3.Where(x => x.men == 15).Where(x => x.nbr != 0).Count()*2;
            int m16 = db.c3.Where(x => x.men == 16).Where(x => x.nbr != 0).Count()*2;
            int m17 = db.c3.Where(x => x.men == 17).Where(x => x.nbr != 0).Count()*2;
            int m18 = db.c3.Where(x => x.men == 18).Where(x => x.nbr != 0).Count()*2;
            int m19 = db.c3.Where(x => x.men == 19).Where(x => x.nbr != 0).Count()*2;
            int m20 = db.c3.Where(x => x.men == 20).Where(x => x.nbr != 0).Count()*2;
            int m21 = db.c3.Where(x => x.men == 21).Where(x => x.nbr != 0).Count()*2;
            int m22 = db.c3.Where(x => x.men == 22).Where(x => x.nbr != 0).Count()*2;
            int m23 = db.c3.Where(x => x.men == 23).Where(x => x.nbr != 0).Count()*2;
            int m24 = db.c3.Where(x => x.men == 24).Where(x => x.nbr != 0).Count()*2;
            int m25 = db.c3.Where(x => x.men == 25).Where(x => x.nbr != 0).Count()*2;


            Ratio obj = new Ratio();
            obj.m1 = m1;
            obj.m2 = m2;
            obj.m3 = m3;
            obj.m4 = m4;
            obj.m5 = m5;
            obj.m6 = m6;
            obj.m7 = m7;
            obj.m8 = m8;
            obj.m9 = m9;
            obj.m10 = m10;
            obj.m11= m11;
            obj.m12 = m12;
            obj.m13 = m13;
            obj.m14 = m14;
            obj.m15 = m15;
            obj.m16 = m16;
            obj.m17 = m17;
            obj.m18 = m18;
            obj.m19 = m19;
            obj.m20 = m20;
            obj.m21 = m21;
            obj.m22 = m22;
            obj.m23= m23;
            obj.m24 = m24;
            obj.m25 = m25;
            return Json(obj, JsonRequestBehavior.AllowGet);
        }
        public class Ratio
        {
            public int m1 { get; set; }
            public int m2 { get; set; }
            public int m3 { get; set; }
            public int m4 { get; set; }
            public int m5 { get; set; }
            public int m6 { get; set; }
            public int m7 { get; set; }
            public int m8 { get; set; }
            public int m9 { get; set; }
            public int m10 { get; set; }
            public int m11{ get; set; }
            public int m12{ get; set; }
            public int m13{ get; set; }
            public int m14{ get; set; }
            public int m15{ get; set; }
            public int m16{ get; set; }
            public int m17{ get; set; }
            public int m18{ get; set; }
            public int m19{ get; set; }
            public int m20{ get; set; }
            public int m21{ get; set; }
            public int m22{ get; set; }
            public int m23{ get; set; }
            public int m24{ get; set; }
            public int m25{ get; set; }

        }
        public class ratio1
        {
            public int m1 { get; set; }
            public int m2 { get; set; }
        }
        public class ratio2
        {
            public int enqueteurs { get; set; }
            public int superviseurs_centrale { get; set; }
            public int superviseurs_regionale { get; set; }
            public int informaticiens { get; set; }
        }
        public class ratio3
        {
            public int niv1 { get; set; }
            public int niv2 { get; set; }
            public int niv3 { get; set; }
            public int niv4 { get; set; }
            public int niv5 { get; set; }

        }
        public class ratio4
        {
            public int an17 { get; set; }
            public int an18 { get; set; }
            public int an19 { get; set; }
            public int an20 { get; set; }
          
        }
    }
}