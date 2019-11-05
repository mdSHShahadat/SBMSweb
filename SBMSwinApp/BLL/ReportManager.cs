using SBMS.Models;
using SBMS.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBMS.BLL
{
    public class ReportManager
    {
        ReportRepository reportRepository = new ReportRepository();
        public List<Report> GetAllReport()
        {
            return reportRepository.GetAllReport();
        }
        public List<Report> GetReportByDateForSales(Report report)
        {

            return reportRepository.GetReportByDateForSales(report);
        }
        public List<Report> GetReportByDateForPurchase(Report report)
        {
           return reportRepository.GetReportByDateForPurchase(report);
        }
    }
}
