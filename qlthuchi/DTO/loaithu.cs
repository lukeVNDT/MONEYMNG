using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qlthuchi.DTO
{
   public class loaithu
    {
        public loaithu(int id, string name)
        {
            this.ID = id;
            this.Name = name;
        }

        public loaithu(DataRow row)
        {
            this.ID = (int)row["id_loaithu"];
            this.Name = row["tenloaithu"].ToString();
        }

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private int iD;

        public int ID
        {
            get { return iD; }
            set { iD = value; }
        }
    }
}
