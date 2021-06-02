
 #include <stdio.h>

 enum dias {segunda, terca, quarta, quinta, sexta, sabado, domingo};


main(void)
 {  int a,b;
	a = segunda;
	b = terca;
	a++;
	if (a==terca)
     puts("Estamos em Terça Feira");
 }
