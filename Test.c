#include "stdio.h"

__declspec( dllexport ) int NativeFunc()
{
	puts("[Test.c] NativeFunc");
    return 123456;
}