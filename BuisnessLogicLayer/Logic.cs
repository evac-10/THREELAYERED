using System.Data;

namespace BuisnessLogicLayer
{
    public class Logic
    {
        private Data studentDAL = new Data();

        public DataTable GetAllStudents()
        {
            return studentDAL.GetStudents();
        }
    }
}
