
 #include <stdio.h>

 enum dias   {segunda=2, terca=3, quarta=4, quinta=5,
			sexta=6, sabado=7, domingo=1};

main(void)
 {  int a,b;
	a = segunda;
	b = terca;
	a++;
	if (a==terca)
     puts("Estamos em Terça Feira");
 }
