using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_lesson_3
{
    abstract class Power_simulator : Training_apparatus // силовые тренажеры
    {
        public string? installation_method;    // Способ установки
        public bool? presence_weight;    //  наличие рабочего веса

    }
}
