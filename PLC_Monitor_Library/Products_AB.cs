using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLC_Monitor_Library
{
    public class Products_AB
    {
        private readonly Dictionary<string, Dictionary<string, Tuple<string, string, string>>> productCodes = new Dictionary<string, Dictionary<string, Tuple<string, string, string>>>
            {
                //Product Type
                {"7", new Dictionary<string, Tuple<string, string, string>>()          
                    {         
                        //Product Codes in this Product Type

                        //1756
                        //Input Cards
                        {"2", new Tuple<string, string, string>("I", "16", "CLX")},                            //1756-IB16D         
                        {"6", new Tuple<string, string, string>("I", "16", "CLX")},                            //1756-IB16I
                        {"11", new Tuple<string, string, string>("I", "16", "CLX")},                           //1756-IB16         
                        {"12", new Tuple<string, string, string>("I", "16", "CLX")},                           //1756-IB32/B
                        {"183", new Tuple<string, string, string>("I", "16", "CLX")},                          //1756-IB16ISOE/A
                        {"386", new Tuple<string, string, string>("I", "16", "CLX")},                          //1756-IB16IF

                        //Output Cards
                        {"4", new Tuple<string, string, string>("O", "16", "CLX")},                                //1756-OB16D
                        {"8", new Tuple<string, string, string>("O", "16", "CLX")},                                //1756-OB16I
                        {"16", new Tuple<string, string, string>("O", "16", "CLX")},                               //1756-OB16E
                        {"17", new Tuple<string, string, string>("O", "32", "CLX")},                               //1756-OB32
                        {"18", new Tuple<string, string, string>("O", "8", "CLX")},                                //1756-OB8
                        {"26", new Tuple<string, string, string>("O", "8", "CLX")},                                //1756-OB8EI
                        {"169", new Tuple<string, string, string>("O", "16", "CLX")},                              //1756-OB16IS
                        {"309", new Tuple<string, string, string>("O", "8", "CLX")},                               //1756-OB8I                        
                        {"388", new Tuple<string, string, string>("O", "16", "CLX")},                              //1756-OB16IEF 
                    
                        //1794
                        //Input Cards
                        {"52", new Tuple<string, string, string>("I", "8", "FLX")},                            //1794-IB8/A

                        //Output Cards
                        {"40", new Tuple<string, string, string>("O", "8", "FLX")}                                 //1794-OB8EP/A 
                    }
                }
            };

        Tuple<string, string, string> holderTuple;
        Dictionary<string, Tuple<string, string, string>> holderDict;
        public Tuple<string, string, string> this[string key1, string key2]
        {
            get 
            {
                holderTuple = null;
                if(productCodes.TryGetValue(key1, out holderDict))
                {
                    holderDict.TryGetValue(key2, out holderTuple);
                }
                
                return holderTuple;  
            }
        }
    }
}
