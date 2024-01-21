namespace mysqlefcore
{
    public class UpdateData
    {

        public static void EditData()
        {
            using (var context = new DoctorContext())
            {

                Console.WriteLine("Current Doctor Details:");
                PrintData.ReadData();


                Console.Write("Enter the DoctorID ");
                int doctorid = Convert.ToInt32(Console.ReadLine());

                var DoctorToUpdate = context.Doctors.FirstOrDefault(b => b.DoctorID == doctorid);

                if (DoctorToUpdate != null)
                {
                    Console.WriteLine("Updating  values into the tables: ");
                    Console.WriteLine("What you want to update");
                    Console.WriteLine("1.DoctorID \n 2.DoctorName \n 3.DoctorAge \n 4.DoctorEmail \n 5.DoctorSpecialization \n 6.DoctorContactNumber \n 7.DoctorLocation");
                    int updatechoice = Convert.ToInt32(Console.ReadLine());
                    string updatedata = null;
                    switch (updatechoice)
                    {
                        case 1:
                            updatedata = "DoctorID";
                            Console.WriteLine($"Current DoctorID: {DoctorToUpdate.DoctorID}");
                            Console.Write("Enter new DoctorId : ");
                            int newid = Convert.ToInt32(Console.ReadLine());
                            DoctorToUpdate.DoctorID = newid;
                            break;

                        case 2:
                            updatedata = "DoctorName";
                            Console.WriteLine($"Current DoctorName: {DoctorToUpdate.DoctorName}");
                            Console.Write("Enter new Doctorname : ");
                            string newdomain = Console.ReadLine();
                            DoctorToUpdate.DoctorName = newdomain;
                            break;

                         case 3:
                            updatedata = "DoctorAge";
                            Console.WriteLine($"Current Age: {DoctorToUpdate.DoctorAge}");
                            Console.Write("Enter new DoctorAge: ");
                            int newname = Convert.ToInt32(Console.ReadLine());
                            DoctorToUpdate.DoctorAge = newname;
                            break;

                        case 4:
                            updatedata = "DoctorEmail";
                            Console.WriteLine($"Current Email: {DoctorToUpdate.DoctorEmail}");
                            Console.Write("Enter new Email: ");
                            string newType = Console.ReadLine();
                            DoctorToUpdate.DoctorEmail = newType;
                            break;


                        case 5:
                            updatedata = "DoctorSpecialization";
                            Console.WriteLine($"Current Specialization: {DoctorToUpdate.DoctorSpecialization}");
                            Console.Write("Enter new DoctorSpecialization: ");
                            string newlang= Console.ReadLine();
                            DoctorToUpdate.DoctorSpecialization = newlang;
                            break;


                        case 6:
                            updatedata = "DoctorContactNumber";
                            Console.WriteLine($"Current Duration: {DoctorToUpdate.DoctorContactNumber}");
                            Console.Write("Enter new ContactNumber: ");
                            int newPage = Convert.ToInt32(Console.ReadLine());
                            DoctorToUpdate.DoctorContactNumber = newPage;
                            break;

                        case 7:
                            updatedata = "DoctorLocation";
                            Console.WriteLine($"Current Location: {DoctorToUpdate.DoctorLocation}");
                            Console.Write("Enter new Location: ");
                            string newlocation = Console.ReadLine();
                            DoctorToUpdate.DoctorLocation = newlocation;
                            break;

                    }

                    context.SaveChanges();

                    Console.WriteLine("Data Updated successfully !");
                }

                else
                {
                    Console.WriteLine($"Doctor with DoctorID {doctorid} not found.");
                }
            }
        }
    }
}