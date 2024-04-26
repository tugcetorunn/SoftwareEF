using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareEF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SoftwareDbContext db = new SoftwareDbContext();
            List<SoftwareList> softwares = db.SoftwareList.ToList();
        }
    }
}
