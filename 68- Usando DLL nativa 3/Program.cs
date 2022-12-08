using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace Usando_DLL_nativa_3
{
    internal class CascaDLLNativa
    {
        [StructLayout(LayoutKind.Sequential)]
        public struct MinhaEstrutura
        {
            public int valor1;
            public double valor2;
            public char valor3;
        };

        [DllImport(@"..\..\DLL\DLL_Nativa.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void RecebeEstrutura(ref MinhaEstrutura minhaEstrutura);

        [DllImport(@"..\..\DLL\DLL_Nativa.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void RecebeEstrutura(IntPtr minhaEstrutura);
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            CascaDLLNativa.MinhaEstrutura minhaEstrutura = new CascaDLLNativa.MinhaEstrutura();
            CascaDLLNativa.RecebeEstrutura(ref minhaEstrutura);
            if (minhaEstrutura.valor1 == 10 && minhaEstrutura.valor2 == 20 && minhaEstrutura.valor3 == 30)
                Console.WriteLine("Estrutura preenchida com sucesso");
            else
                Console.WriteLine("Estrutura NÃO preenchida com sucesso");

            IntPtr minhaEstruturaPtr = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(CascaDLLNativa.MinhaEstrutura)));
            CascaDLLNativa.RecebeEstrutura(minhaEstruturaPtr);
            CascaDLLNativa.MinhaEstrutura minhaEstruturaConvertida = (CascaDLLNativa.MinhaEstrutura)Marshal.PtrToStructure(minhaEstruturaPtr, typeof(CascaDLLNativa.MinhaEstrutura));
            if (minhaEstruturaConvertida.valor1 == 10 && minhaEstruturaConvertida.valor2 == 20 && minhaEstruturaConvertida.valor3 == 30)
                Console.WriteLine("Estrutura preenchida com sucesso");
            else
                Console.WriteLine("Estrutura NÃO preenchida com sucesso");

            Console.ReadKey();

        }
    }
}
