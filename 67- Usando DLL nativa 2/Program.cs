using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace Usando_DLL_nativa_2
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
        public static extern void LimpaMemoria();

        [DllImport(@"..\..\DLL\DLL_Nativa.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr RetornaString();

        [DllImport(@"..\..\DLL\DLL_Nativa.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr RetornaArrayDeBytes();

        [DllImport(@"..\..\DLL\DLL_Nativa.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void RecebeEstrutura(ref MinhaEstrutura minhaEstrutura);

        [DllImport(@"..\..\DLL\DLL_Nativa.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern bool EnviaEstrutura(ref MinhaEstrutura minhaEstrutura);

        [DllImport(@"..\..\DLL\DLL_Nativa.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr RetornaEstrutura();
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            IntPtr ptrParaStr = CascaDLLNativa.RetornaString();
            string minhaString = Marshal.PtrToStringAnsi(ptrParaStr);
            CascaDLLNativa.LimpaMemoria();
            Console.WriteLine(minhaString);


            IntPtr ptrParaByteArray = CascaDLLNativa.RetornaArrayDeBytes();
            byte[] byteArray = new byte[3];
            Marshal.Copy(ptrParaByteArray, byteArray, 0, 3);
            CascaDLLNativa.LimpaMemoria();
            if (byteArray[0] == 0 && byteArray[1] == 1 && byteArray[2] == 2)
                Console.WriteLine("Array de bytes retornado com sucesso");
            else
                Console.WriteLine("Array de bytes NÃO retornado com sucesso");

            CascaDLLNativa.MinhaEstrutura minhaEstrutura = new CascaDLLNativa.MinhaEstrutura();
            CascaDLLNativa.RecebeEstrutura(ref minhaEstrutura);
            if(minhaEstrutura.valor1 == 10 && minhaEstrutura.valor2 == 20 && minhaEstrutura.valor3 == 30)
                Console.WriteLine("Estrutura preenchida com sucesso");
            else
                Console.WriteLine("Estrutura NÃO preenchida com sucesso");

            CascaDLLNativa.MinhaEstrutura minhaEstrutura2 = new CascaDLLNativa.MinhaEstrutura();
            minhaEstrutura2.valor1 = 10;
            minhaEstrutura2.valor2 = 20;
            minhaEstrutura2.valor3 = 'a';
            bool retornoEnviaEstrutura = CascaDLLNativa.EnviaEstrutura(ref minhaEstrutura2);
            if(retornoEnviaEstrutura == true)
                Console.WriteLine("Estrutura recebida corretamente na DLL nativa");
            else
                Console.WriteLine("Estrutura NÃO recebida corretamente na DLL nativa");


            IntPtr ptrParaStruct = CascaDLLNativa.RetornaEstrutura();
            CascaDLLNativa.MinhaEstrutura minhaEstrutura3 = new CascaDLLNativa.MinhaEstrutura();
            minhaEstrutura3 = (CascaDLLNativa.MinhaEstrutura)Marshal.PtrToStructure(ptrParaStruct, typeof(CascaDLLNativa.MinhaEstrutura));
            CascaDLLNativa.LimpaMemoria();
            if (minhaEstrutura3.valor1 == 10 && minhaEstrutura3.valor2 == 20 && minhaEstrutura3.valor3 == 30)
                Console.WriteLine("Estrutura retornada com sucesso");
            else
                Console.WriteLine("Estrutura NÃO retornada com sucesso");

            Console.ReadKey();
        }
    }
}
