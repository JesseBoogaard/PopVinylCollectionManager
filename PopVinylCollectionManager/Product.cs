using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PopVinylCollectionManager {
    class Product {
        private string _Name { get; set; }
        private string _Series;
        private long _ProductNo { get; set; }
        private string _ImgURL { get; set; }

        public Product(string Name, int ProductNo, string Series) {
            _Name = Name;
            _ProductNo = ProductNo;
            _Series = Series;
        }

        public override string ToString() {
            return "Name: " + _Name + "\t ProductNo.: " + _ProductNo + "\t Series: " + _Series;
        }
    }
}
