using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace tubesAKHIR_Kelompok5.Libs
{
    public class Transaction
    {
        public string trxId
        {
            get; set;
        }

        public string trxType
        {
            get; set;
        }

        public List<Item> data
        {
            get; set;
        }
        public string trxTotal
        {
            get; set;
        }

        public string createJson()
        {
            string jsonString = JsonSerializer.Serialize(this);
            return jsonString;
        }

    }

}
