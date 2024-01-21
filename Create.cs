namespace mysqlefcore
{
    public class CreateData
    {
        public static void InsertData()
        {
            using (var context = new DoctorContext())
            {
                //Creates the database if not exists
                context.Database.EnsureCreated();

        

                Console.WriteLine("Enter DoctorID");
                int doctorid = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter DoctorName");
                string doctorName = Console.ReadLine();
                Console.WriteLine("Enter DoctorAge");
                int doctorage =Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter DoctorEmail");
                string doctoremail = Console.ReadLine();
                Console.WriteLine("Enter DoctorSpecialization");
                string doctorspecialization = Console.ReadLine();
                Console.WriteLine("Enter DoctorContactNumber");
                int doctorcontactnumber = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter DoctorLocation");
                string doctorlocation = Console.ReadLine();
                
                context.Doctors.Add(new Doctor
                {
                    DoctorID = doctorid,
                    DoctorName = doctorName,
                    DoctorAge = doctorage,
                    DoctorEmail = doctoremail,
                    DoctorSpecialization = doctorspecialization,
                    DoctorContactNumber = doctorcontactnumber,
                    DoctorLocation = doctorlocation

                }
            );



                context.SaveChanges();
                Console.WriteLine("Data Inserted Successfully ! ");
            }
        }
    }
}