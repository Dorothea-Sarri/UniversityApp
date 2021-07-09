using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Impl {
   public class Entity {
        public Guid ID { get; set; }
        public Entity() {

            ID = Guid.NewGuid();
        }
    }
}
