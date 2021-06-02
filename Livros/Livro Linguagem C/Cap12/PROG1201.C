#include <stdio.h>
#include <string.h>

main()
{ char s[200], 
       outra[200]; /* 200 posições - não vá o diabo tecê-las */

  printf("Qual a sua String:"); gets(s);
  
  /* Colocar na string outra uma cópia da string s */

  strcpy(outra,s);

  printf("String Original: %s\nCopia: %s\n",s,outra);
}
