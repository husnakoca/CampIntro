using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    class CoorporateCustomer:Customer
    {
       
        public string CompanyName { get; set; }
        public string TaxNumber { get; set; }
        //string sayıda kullanıyosak matematiksel işlem olmadığı sürece metinsel olarak planlarsak daha iyi sonuçlar alırız
        //eğer bir nesnede bir değeri kullanmak zoruunda gibi görünmüyosam orayaa ait değil gibi duruyosa soyutlama hatası vardır
    }
}
