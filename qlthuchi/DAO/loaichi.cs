using qlthuchi.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qlthuchi.DAO
{
    class danhmucchidao
    {

        private static danhmucchidao instance;

        public static danhmucchidao Instance
        {
            get { if (instance == null) instance = new danhmucchidao(); return danhmucchidao.instance; }
            private set { danhmucchidao.instance = value; }
        }
        private danhmucchidao() { }

        public List<loaichi> GetListCategory()
        {
            List<loaichi> list = new List<loaichi>();

            string query = "select * from dbo.loaichi";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                loaichi category = new loaichi(item);
                list.Add(category);
            }

            return list;
        }
        
    }
}
