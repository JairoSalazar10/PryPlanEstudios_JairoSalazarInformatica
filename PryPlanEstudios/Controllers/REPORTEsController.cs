using CapaNegocio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PryPlanEstudios.Controllers
{
    public class REPORTEsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: REPORTEs
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult RepEstudianteSexo()
        {
            return View();
        }

        [HttpPost]
        public JsonResult RepEstudianteSexo(int i)
        {
            List<object> iData = new List<object>();
            DataTable dt = new DataTable();

            dt.Columns.Add("Genero", System.Type.GetType("System.String"));
            dt.Columns.Add("Total", System.Type.GetType("System.Int32"));

            var exs = (from s in db.ESTUDIANTEs
                       group new { s } by new { s.EST_SEXO } into g
                       orderby g.Key.EST_SEXO ascending
                       select new
                       {
                           genero = g.Key.EST_SEXO,
                            total = g.Count()
                       }).ToList();

            foreach (var item in exs)
            {
                DataRow dr = dt.NewRow();

                dr["Genero"] = item.genero;
                dr["Total"] = item.total;

                dt.Rows.Add(dr);
            }

            foreach (DataColumn dc in dt.Columns)
            {
                List<object> x = new List<object>();
                x = (from DataRow drr in dt.Rows select drr[dc.ColumnName]).ToList();
                iData.Add(x);
            }

            return Json(iData, JsonRequestBehavior.AllowGet);

        }


        public ActionResult RepFacultadxEstudiante()
        {
            return View();
        }

        [HttpPost]
        public JsonResult RepFacultadxEstudiante(int i)
        {
            List<object> iData = new List<object>();
            DataTable dt = new DataTable();

            dt.Columns.Add("Facultad", System.Type.GetType("System.String"));
            dt.Columns.Add("Total", System.Type.GetType("System.Int32"));

            var fac =
                (from fa in db.FACULTAD
                 join ca in db.CARRERAs on fa.FAC_ID equals ca.FAC_ID
                 join pa in db.PLAN on ca.CAR_ID equals pa.CAR_ID
                 join es in db.ESTUDIANTEs on pa.PLA_ID equals es.PLA_ID
                 group new { fa } by new { fa.FAC_NOMBRE } into g
                 orderby g.Key.FAC_NOMBRE ascending

                 select new
                 {
                     facultad = g.Key.FAC_NOMBRE,
                     total = g.Count()

                 }).ToList();

            foreach (var item in fac)
            {
                DataRow dr = dt.NewRow();

                dr["Facultad"] = item.facultad;
                dr["Total"] = item.total;

                dt.Rows.Add(dr);
            }

            foreach (DataColumn dc in dt.Columns)
            {
                List<object> x = new List<object>();
                x = (from DataRow drr in dt.Rows select drr[dc.ColumnName]).ToList();
                iData.Add(x);
            }

            return Json(iData, JsonRequestBehavior.AllowGet);
        }
    }
}