using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PopVinylCollectionManager {
    class Product {
        private string _Name { get; set; }
        private int _Series { get; set; }
        private long _ProductNo { get; set; }
        private string _ImgURL { get; set; }

        public Product(string Name, int Series, long ProductNo, string URL) {
            _Name = Name;
            _Series = Series;
            _ProductNo = ProductNo;
            _ImgURL = URL;
        }
    }
}
