//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Collections;
//using System.Data.SqlClient;

//namespace OrderTogether
//{
   


//    public struct PersonInfo
//    {
//        public int _classId;
//        public string _className;
//        public string _userName;

//        public PersonInfo(int classId, string className, string userName)
//        {
//            _classId = classId;
//            _className = className;
//            _userName = userName;
//        }

//    }

//    public struct ShopInfo
//    {
//        public int _shopId;
//        public string _shopName;
//        public string _shopMenu;
//        public int _menuPrice;
//        public string _shopPhone;

//        public ShopInfo(int shopId, string shopName, string shopMenu, int menuPrice)
//        {
//            _shopId = shopId;
//            _shopName = shopName;
//            _shopMenu = shopMenu;
//            _menuPrice = menuPrice;
//            _shopPhone = "";
//        }
//        public ShopInfo(int shopId, string shopName, string shopMenu, int menuPrice, string shopPhone)
//        {
//            _shopId = shopId;
//            _shopName = shopName;
//            _shopMenu = shopMenu;
//            _menuPrice = menuPrice;
//            _shopPhone = shopPhone;
//        }
//    }
//    class Database
//    {
//        //==========================================================================================================
        

//        //public string Get_ClassName()
//        //{
//        //    //SqlConnection con = new SqlConnection(myDBConnectionString);
//        //    //con.Open();
//        //    //string strSQL = "select classes from Class_Name;";
//        //    //SqlCommand cmd = new SqlCommand(strSQL, con);
//        //    //SqlDataReader reader = cmd.ExecuteReader();

//        //    //string strMsg = "";

//        //    //while (reader.Read())
//        //    //{
//        //    //    strMsg += string.Format("{0}", reader["classes"]);

//        //    //}

//        //    //reader.Close();
//        //    //con.Close();
//        //    //Console.WriteLine(strMsg);
//        //    //return strMsg;
//        //}
//        //==========================================================================================================
//        public static string mainOrderPerson = ""; //主要訂購人
//        public static string shopPhone = "";



//        public List<PersonInfo> personInfo = new List<PersonInfo>()
//        {   new PersonInfo(1,"一年一班","王小明"),
//            new PersonInfo(1,"一年一班","王小美"),
//            new PersonInfo(1,"一年一班","王小白"),
//            new PersonInfo(2,"一年二班","李小明"),
//            new PersonInfo(2,"一年二班","李小美"),
//            new PersonInfo(2,"一年二班","李小白"),
//            new PersonInfo(3,"一年三班","王小明"),
//            new PersonInfo(3,"一年三班","王小美"),
//            new PersonInfo(3,"一年三班","王小白"),
//        };

//        public List<ShopInfo> shopInfo = new List<ShopInfo>
//        {
//            new ShopInfo(1,"正宗排骨飯","炸雞腿飯__",90,"(07)372-2888"),
//            new ShopInfo(1,"正宗排骨飯","燒雞腿飯__",90),
//            new ShopInfo(1,"正宗排骨飯","正宗排骨飯",80),
//            new ShopInfo(1,"正宗排骨飯","黑胡椒豬排飯",80),
//            new ShopInfo(2,"丹丹漢堡  ","赤肉羹麵線",36,"(07)375-7671"),
//            new ShopInfo(2,"丹丹漢堡  ","烤醬雞堡__",39),
//            new ShopInfo(2,"丹丹漢堡  ","酥皮炸雞__",39),
//            new ShopInfo(2,"丹丹漢堡  ","五穀瘦肉粥",36),
//            new ShopInfo(3,"大埔鐵板燒","香煎雞腿排 ",200,"(07)373-3857"),
//            new ShopInfo(3,"大埔鐵板燒","香煎鱈魚__",150),
//            new ShopInfo(3,"大埔鐵板燒","香煎巴沙魚",140),
//            new ShopInfo(3,"大埔鐵板燒","鐵板豆腐__",120),
//            new ShopInfo(3,"大埔鐵板燒","香煎荷包蛋",15),
//            new ShopInfo(4,"阿益蕎麥麵","日式蕎麥涼麵",60,"(07)799-8298"),
//            new ShopInfo(4,"阿益蕎麥麵","日式綠藻涼麵",70),
//            new ShopInfo(4,"阿益蕎麥麵","餛飩湯麵__",50),
//            new ShopInfo(4,"阿益蕎麥麵","麻將乾麵__",40),
//            new ShopInfo(5,"苓雅油煎肉圓","清蒸肉圓__",30,"(07)339-4226"),
//            new ShopInfo(5,"苓雅油煎肉圓","油煎肉圓__",30),
//            new ShopInfo(5,"苓雅油煎肉圓","桶仔米糕",30),
//            new ShopInfo(5,"苓雅油煎肉圓","豬腸四神湯",30),
//            new ShopInfo(6,"ONE-R章魚燒","經典章魚燒",60,"(07)269-3609"),
//            new ShopInfo(6,"ONE-R章魚燒","墨魚章魚燒",70),
//            new ShopInfo(6,"ONE-R章魚燒","經典明太子",90),
//            new ShopInfo(6,"ONE-R章魚燒","墨魚明太子 ",90),
//            new ShopInfo(6,"ONE-R章魚燒","松露白醬__",120),
//            new ShopInfo(7,"瀧澤軒食堂","博多豚骨拉麵",160,"(07)713-6268"),
//            new ShopInfo(7,"瀧澤軒食堂","蒜香豚骨拉麵",180),
//            new ShopInfo(7,"瀧澤軒食堂","蔥花泡菜拉麵",200),
//            new ShopInfo(7,"瀧澤軒食堂","醬油雞白湯拉麵",250),

//        };


//        public void AddAllData()
//        {
//            int[] shopId = GetShopId();
//            string[] shopName = GetShopName();
//            string[] className = GetClassName();
//            //string[] shopPhone = GetShopPhone(shopName[2]);
//            string[] shopMenu = GetShopMenu(shopName[0]);
//            string[] personName = GetPersonName(className[2]);
//            int[] menuPrice = GetMenuPrice(shopMenu[0]);

//            for (int i = 0; i < shopName.Length; i++)
//            {
//                shopMenu = GetShopMenu(shopName[i]);
//                for (int j = 0; j < shopMenu.Length; j++)
//                {
//                    menuPrice = GetMenuPrice(shopMenu[j]);
//                    foreach (var item in menuPrice)
//                    {
//                        Console.WriteLine(item);
//                    }
//                }
//            }

//        }
//        //主一層所有店家 班級===========================================================================================================================

//        public int[] GetShopId() //取得所有店家ID
//        {
//            List<ShopInfo> shopTemp = shopInfo;
//            var shopId = shopTemp.Select(m => m._shopId).Distinct().ToArray(); //distinct移除重複
//            return shopId;
//        }
//        public string[] GetShopName() //取得所有店家名
//        {
//            List<ShopInfo> shopTemp = shopInfo;
//            var shopId = shopTemp.Select(m => m._shopName).Distinct().ToArray(); //distinct移除重複
//            return shopId;
//        }

//        public string[] GetClassName() //取得所有班級名
//        {
//            List<PersonInfo> classTemp = personInfo;
//            var className = classTemp.Select(m => m._className).Distinct().ToArray(); //distinct移除重複
//            //classtemp
//            return className;
//        }
//        //次二層Name Menu price phone=======================================================================================================

//        public string[] GetPersonName(string className) //取得預設同學名
//        {
//            var personName = personInfo.Where(m => m._className == className).Select(m => m._userName).ToArray();
//            //classtemp
//            return personName;
//        }
//        public string[] GetShopMenu(string shopName) //取得特定店家Menu 
//        {
//            var shopMenu = shopInfo.Where(m => m._shopName == shopName).Select(m => m._shopMenu).ToArray();
//            return shopMenu;
//        }
//        public int[] GetMenuPrice(string shopMenu) //取得特定店家Menu價格
//        {
//            var menuPrice = shopInfo.Where(m => m._shopMenu == shopMenu).Select(m => m._menuPrice).ToArray();
//            return menuPrice;
//        }
//        public string GetShopPhone(string shopName) //取得特定店家電話 
//        {
//            var sP = shopInfo.Where(m => m._shopName == shopName && m._shopPhone != "").Select(m => m._shopPhone).ToArray();
//            foreach (var item in sP)
//            {
//                shopPhone = item;
//            }
//            return shopPhone;
//        }
//        //================================================================================================================================
//    }
//}
