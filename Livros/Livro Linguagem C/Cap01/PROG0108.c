#include <stdio.h>

main()
{
  printf("Programa que apresenta os Caracteres Especiais\n\n");
  printf("\\n\t-\t<ENTER>\n");   /* Output: \n      -       <ENTER> */
  printf("\\\\\t-\t\\\n");       /* Output: \\      -       \       */
  printf("\\t\t-\t<TAB>\n");     /* Output: \t      -       <TAB>   */
  printf("%%%%\t-\t%%\n");       /* Output: %%      -       %       */
}
