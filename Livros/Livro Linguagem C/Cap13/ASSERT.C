#include <assert.h>
#include <stdio.h>

void Inc_Idade(int *ptr_idade)
 {
	assert(ptr_idade!=NULL);
	assert(*ptr_idade>=0);
	(*ptr_idade)++;
 }


main(void)
 {	 int x=5;
	 Inc_Idade (&x);
	 x=-5;
	 Inc_Idade (&x);
	 Inc_Idade (NULL);

 }
