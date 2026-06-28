#include <string.h>

char *remove_char(char *dst, const char *src) {
    /* `src` is the input string */
    /* your solution should write the result into `dst` and return it */
    /* `dst` has room for strlen(src) - 1 bytes */
    int str_size = strlen(src);
    int j = 0;
  
    for (int i = 1; i < (str_size - 1); i++)
    {
      dst[j] = src[i];
      j++;
    }
  
    dst[j] = '\0';
    return dst;
}
