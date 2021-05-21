#include <stdio.h>
#include <stddef.h>

typedef struct
{
  int Campo1;
  double Campo2[100];
  char Campo3[20];
} REG;


main()
{

printf("Campo1 começa no Offset %d\n", offsetof(REG,Campo1));
printf("Campo2 começa no Offset %d\n", offsetof(REG,Campo2));
printf("Campo3 começa no Offset %d\n", offsetof(REG,Campo3));

}
