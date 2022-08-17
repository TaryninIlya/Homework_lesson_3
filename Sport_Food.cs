using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_lesson_3
{
    abstract class Sport_Food : Product_Range, Validity       // спорт инвентарь
    {
        public float? Net_weight;     // масса нетто
        public float? gross_weight;     // масса  брутто
        public string deadline_validity;      // дата истечения срока годности
        public string date_validity;         // дата истечения срока годности
        //
        


    }
}
