#include <stdlib.h>
#include <string.h>

const char* const msg = "Hello from DLL";

__declspec(dllexport) void* GetString()
{
    size_t len = strlen(msg) + 1;
    char* str = (char*)(malloc(len * sizeof(char)));
    if (str != 0)
    {
        strncpy_s(str, len, msg, len);
    }
    return str;
}

__declspec(dllexport) void FreeMemory(void* ptr)
{
    free(ptr);
}
