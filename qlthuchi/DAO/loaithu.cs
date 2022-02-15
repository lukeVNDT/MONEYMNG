using qlthuchi.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qlthuchi.DAO
{
   public class loaithu
    {


        private static loaithu instance;

            public static loaithu Instance
        {
            get { if (instance == null) instance = new loaithu(); return loaithu.instance; }
            private set => loaithu.instance = value;
        }

        private loaithu() { }

            public List<DTO.loaithu> GetListCategory()
            {
            List<DTO.loaithu> list = new List<DTO.loaithu>();

                string query = "select * from dbo.loaithu";

                DataTable data = DataProvider.Instance.ExecuteQuery(query);

                foreach (DataRow item in data.Rows)
                {
                DTO.loaithu category = new DTO.loaithu(item);
                    list.Add(category);
                }

                return list;
            }
    }
}
