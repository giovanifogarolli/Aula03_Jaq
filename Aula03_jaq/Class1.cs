using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula03_jaq
{
    internal class Pedido
    {
        private string Cliente;
        private double ValorTotal;
        private double CaloriasTotal;
        private double[] CaloriasPao = { 108, 100 };
        private double[] CaloriasCarne = { 200, 180 };
        private double[] CaloriasComplemento = { 25, 30, 10, 50 };
        private double[] PrecoPao = { 5, 7 };
        private double[] PrecoCarne = { 15, 13 };
        private double[] PrecoComplemento = { 2, 1, 2, 0 };
 
        public string Cliente1 { get => Cliente; set => Cliente = value; }
        public double ValorTotal1 { get => ValorTotal; set => ValorTotal = value; }
        public double CaloriasTotal1 { get => CaloriasTotal; set => CaloriasTotal = value; }
        public double[] CaloriasPao1 { get => CaloriasPao; set => CaloriasPao = value; }
        public double[] CaloriasCarne1 { get => CaloriasCarne; set => CaloriasCarne = value; }
        public double[] CaloriasComplemento1 { get => CaloriasComplemento; set => CaloriasComplemento = value; }
        public double[] PrecoPao1 { get => PrecoPao; set => PrecoPao = value; }
        public double[] PrecoCarne1 { get => PrecoCarne; set => PrecoCarne = value; }
        public double[] PrecoComplemento1 { get => PrecoComplemento; set => PrecoComplemento = value; }

    }
}
