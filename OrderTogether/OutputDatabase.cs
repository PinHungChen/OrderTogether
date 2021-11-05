//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Collections;
//using System.Data.SqlClient;

//namespace OrderTogether
//{

//    public struct OrderList
//    {
//        public string _classNameOutput;
//        public string _userNameOutput;
//        public string _shopNameOutput;
//        public string _shopMenuOutput;
//        public int _countOutput;
//        public int _menuPriceOutput;
//        public string _paystatus;

//        public OrderList(string classNameOutput, string userNameOutput, string shopNameOutput, string shopMenuOutput, int countOutput, int menuPriceOutput, string paystatus)
//        {
//            _classNameOutput = classNameOutput;
//            _userNameOutput = userNameOutput;
//            _shopNameOutput = shopNameOutput;
//            _shopMenuOutput = shopMenuOutput;
//            _countOutput = countOutput;
//            _menuPriceOutput = menuPriceOutput;
//            _paystatus = paystatus;
//        }
//    }



//    class OutputDatabase//全域變數儲存輸入
//    {
        
//        public void InputOrderListToSQL()
//        {

//        }

//        //==============================================================================================
//        Database databases = new Database();

//        public static List<OrderList> ggg = new List<OrderList>();  //儲存全部
//        public static List<OrderList> ggg1 = new List<OrderList>(); //儲存班一
//        public static List<OrderList> ggg2 = new List<OrderList>(); //儲存班二
//        public static List<OrderList> ggg3 = new List<OrderList>(); //儲存班三
//        public int totalPriceByShop = 0;
//        public string orderListByShop = "";
//        public int totalPriceByClass = 0;
//        public string orderListByClass = "";
//        public static List<ArrayList> d = new List<ArrayList>();


//        //get outputdata-------------------------------------------------------------
//        void GetOutputDatabase()
//        {
//            var className = OutputDatabase.ggg.Select(m => m._classNameOutput + "\t" + m._userNameOutput + "\t" + m._shopNameOutput + "\t" + m._shopMenuOutput + "\t" + m._countOutput + "\t$" + m._menuPriceOutput + "\t$" + m._countOutput * m._menuPriceOutput + "\t" + m._paystatus).ToArray(); //輸出

//        }

//        public string[] GetOutputShop()
//        {
//            var shopName = OutputDatabase.ggg.Select(m => m._shopNameOutput).Distinct().ToArray(); //輸出
//            return shopName;
//        }

//        public string[] GetOutputClass()
//        {
//            var shopName = OutputDatabase.ggg.Select(m => m._classNameOutput).Distinct().ToArray(); //輸出

//            return shopName;
//        }


        


//    }

//}
