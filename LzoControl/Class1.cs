using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Threading;
using System.Runtime.InteropServices.WindowsRuntime;

namespace LzoControl
{
    public unsafe class Lzo1x
    {
        [DllImport("LzoC.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int LzoCompre(byte* input, int inLen, byte* output, int* outLen);
        [DllImport("LzoC.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int LzoDecompress(byte* input, int inLen, byte* output, int* outLen);

        unsafe public int Comprress(byte[] input,int inlen,byte[] output,out int outlen)
        {
            int outlenLocal = 0;
            int lzoint;
            fixed(byte* inp = input)
            {
                fixed(byte* outp = output)
                {
                   lzoint = LzoCompre(inp, inlen, outp, &outlenLocal);
                }
            }
            outlen = outlenLocal;
            return lzoint;
        }

        unsafe public int Decompress(byte[] input, int inlen, byte[] output, out int outlen)
        {
            int outlenLocal = 0;
            int lzoint;
            fixed (byte* inp = input)
            {
                fixed (byte* outp = output)
                {
                    lzoint = LzoDecompress(inp, inlen, outp, &outlenLocal);
                }
            }
            outlen = outlenLocal;
            return lzoint;
        }
    }
}
