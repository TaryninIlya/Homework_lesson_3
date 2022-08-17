using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_lesson_3
{
    abstract class Sports_Uniforms: Product_Range        // спортивная одежда
    {
        public string? size;    // размер одежды
        public bool gender;    // Пол true - женский ; false - мужской 
        public string? material;    // материал
    }
}
