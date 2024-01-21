using System.Text;
using Microsoft.EntityFrameworkCore;

namespace mysqlefcore
{
  public class PrintData
  {
  
        public static void ReadData()
    {
      using (var context = new DoctorContext())
      {
         var doc = context.Doctors;


                foreach (var Doctors in context.Doctors)
        {
          var data = new StringBuilder();
          data.AppendLine($"DoctorID: {Doctors.DoctorID}");
          data.AppendLine($"DoctorName: {Doctors.DoctorName}");
          data.AppendLine($"DoctorAge:{Doctors.DoctorAge}");
          data.AppendLine($"DoctorEmail:{Doctors.DoctorEmail}");
          data.AppendLine($"DoctorSpecialization:{Doctors.DoctorSpecialization}");
          data.AppendLine($"DoctorContactNumber:{Doctors.DoctorContactNumber}");
          data.AppendLine($"DoctorLocation:{Doctors.DoctorLocation}");
          Console.WriteLine(data.ToString());

     
        }


            }
    }
  }
}

