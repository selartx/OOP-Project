namespace OOPPROJECT
{
    public class Staff
    {

        public string StaffName { get; set; }
        public string StaffLastname { get; set; }
        public int StaffPassword { get; set; }
        public Staff(string staffName, string staffLastname, int staffPassword)
        {
            StaffName=staffName;
            StaffLastname=staffLastname;
            StaffPassword=staffPassword;
        }

    }
}
