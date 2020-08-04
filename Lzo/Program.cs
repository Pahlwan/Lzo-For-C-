using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using LzoControl;

namespace Lzo
{
    unsafe class Program
    {
        
           
        //[DllImport("LzoC.dll")]
        //public static extern void LzoCompress( );
        [DllImport("LzoC.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern char* LzoCompre(char* input,int inLen,char* output,int *outLen);
        [DllImport("LzoC.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern char* LzoDecompress(char* input, int inLen, char* output, int* outLen);


        //unsafe static void Main(string[] args)
        //{
        //    //byte[] output = Encoding.ASCII.GetBytes("null");
        //    //byte[] input = Encoding.ASCII.GetBytes("Mukesh");
        //    int ilen = 23;
        //    int olen = 10;
        //    string input1 = "s54d*73 *73 *73 *736 *7378";
        //    string output1 = "Output";
        //    //LzoCompress( );
        //    fixed(char *inp = input1)
        //    {
        //        fixed(char *outp = output1)
        //        {
        //            outp[1] = 'p';


        //                char* ol = LzoCompre(inp, ilen, outp, &olen);
        //                string output3 = "";
        //                for (int i = 0; i < olen; i++)
        //                {
        //                    Console.Write(outp[i]);
        //                }

        //            //fixed(char * din = output3)
        //            //{
        //            //    for(int i = 0;i<olen;i++)
        //            //    {
        //            //        din[0] = myo[0];
        //            //    }
        //            //    char*  res = LzoDecompress(din, olen, outp, &olen);

        //            //}
        //            Console.WriteLine(output1);
        //        }
        //    }

        //    string doutput = "asfasf";
        //    int clen = 5;
        //    fixed(char *din = output1)
        //    {
        //        fixed(char *dout = doutput )
        //        {
        //            LzoDecompress(din, olen, dout, &clen);
        //        }
        //    }
        //    Console.WriteLine(doutput);



        //    Console.ReadKey();
        //}

        [DllImport("LzoC.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern char* LzoCompre(byte* input, int inLen, byte* output, int* outLen);
        [DllImport("LzoC.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern char* LzoDecompress(byte* input, int inLen, byte* output, int* outLen);

        unsafe static void Main()
        {
            byte[] input = Encoding.ASCII.GetBytes("Mukesh");
            byte[] output = new byte[20];
            int outlen;
            LzoControl.LzoControl lzoControl = new LzoControl.LzoControl();
            lzoControl.Comprress(input, 6, output, out outlen);
            byte[] outputd = new byte[6];
            int outlend;
            lzoControl.Decompress(output, 10, outputd, out outlend);
            //fixed (byte* inb = input)
            //{
            //    fixed(byte *outb = output)
            //    {
            //        LzoCompre(inb, 6, outb, &outlen);
            //    }
            //}

            //byte[] outd = new byte[6];
            //fixed(byte * inb = output)
            //{ 
            //    fixed(byte* outb = outd)
            //    {
            //        LzoDecompress(inb, 10, outb, &outlen);

            //    }
            //}
            //Console.WriteLine(Encoding.ASCII.GetString(outd));

            
        }
        
        

    }
}
