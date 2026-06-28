#include <stdbool.h>
#include <stddef.h>

size_t count_sheep(const bool sheep[/* count */], size_t count)
{
  size_t present_sheep = 0;

  for (size_t i = 0; i < count; i++) {
    if (sheep[i] == true) {
      present_sheep++;
    }
  }
  
  return present_sheep;
}
