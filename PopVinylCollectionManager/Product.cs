using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PopVinylCollectionManager {
    class Product {
        private string _Name { get; set; }
        private int _SeriesID;
        private long _ProductNo { get; set; }
        private string _ImgURL { get; set; }

        public Product(string Name, int SeriesID, long ProductNo) {
            _Name = Name;
            _SeriesID = SeriesID;
            _ProductNo = ProductNo;
        }
    }
}
