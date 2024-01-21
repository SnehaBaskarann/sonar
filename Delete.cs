namespace mysqlefcore
{
   public class DeleteData
   {

      public static void RemoveData()
      {

         {
            using (var context = new DoctorContext())
            {

               Console.WriteLine("Current Details:");
               PrintData.ReadData();

               Console.Write("Enter Your DoctorID ");
               int doctorid = Convert.ToInt32( Console.ReadLine());


               var DoctorNameToRemove = context.Doctors.FirstOrDefault(b => b.DoctorID == doctorid);

               if (DoctorNameToRemove!= null)
               {

                  Console.WriteLine($"Removing Doctor - ID: {DoctorNameToRemove.DoctorID}, Doctor Name: {DoctorNameToRemove.DoctorName}");


                  context.Doctors.Remove(DoctorNameToRemove);


                  context.SaveChanges();

                  Console.WriteLine("Data Removed successfully !");
               }
               else
               {
                   Console.WriteLine($"Doctor with DoctorID {doctorid} not found.");
               }
            }
         }
      }
   }
}

