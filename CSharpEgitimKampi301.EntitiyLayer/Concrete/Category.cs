using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi301.EntitiyLayer.Concrete
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public bool CategoryStatus { get; set; }
        public List<Product> products { get; set; }

    }
}

/*
 field(alan)-variable(değişken)-property(özellik)

bir classın içinde tanımlanan değişkenler field olarak adlandırılır (int x; -->field)
public int CategoryId { get; set; } --> property
methodun içinde tanımlanan değişkenler ise variable olarak adlandırılır (void test()
                                                                       {
                                                                                int z;
                                                                       })
 */
