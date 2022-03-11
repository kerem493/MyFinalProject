using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public  static class Messages
    {
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductNameImvalid = "Ürün ismi geçersiz";
        public static string MaintenanceTime = "Sistem bakımda";
        public static string ProductsListed = "Ürünler listelendi";
        public static string ProductCountOfCategoryError = "Bir kategoride en fazla 10 ürün olabilir.";
        public static string ProductNameAlreadyExists = "Bu isimde başka bir ürün var.";
        internal static string CategoryLimitExceded = "Kategori limiti aşıldığı için yeni ürün eklenemiyo.";
    }
}
