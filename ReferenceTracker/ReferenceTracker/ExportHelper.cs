using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ReferenceTracker
{
    public class ExportHelper
    {
        public void ExportPapers(DataTable dtPapers)
        {
            foreach( DataRow dr in dtPapers.Rows)
            {
                string fileName = DateTime.Now.Year.ToString() + "_" + DateTime.Now.Month.ToString() + "_" + DateTime.Now.Day.ToString();
                //File.Create()
                
            }
        }
    }
}
