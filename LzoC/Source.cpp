
extern "C"
{
    #include<stdio.h>
    #include "minilzo.h"
    #define IN_LEN      (128*1024ul)
    #define OUT_LEN     (IN_LEN + IN_LEN / 16 + 64 + 3)

    static unsigned char __LZO_MMODEL in[IN_LEN];
    static unsigned char __LZO_MMODEL out[OUT_LEN];

    #define HEAP_ALLOC(var,size) \
    lzo_align_t __LZO_MMODEL var [ ((size) + (sizeof(lzo_align_t) - 1)) / sizeof(lzo_align_t) ]

    static HEAP_ALLOC(wrkmem, LZO1X_1_MEM_COMPRESS);


    __declspec(dllexport) void LzoCompress()
    {
        printf("Compression is done.");
    }
}