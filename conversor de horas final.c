#include <stdio.h>

main()

{
	
	char what;
	float hora;
	float minuto;
	float segundo;

	minuto = 60;
	segundo = 3600;

	printf ("quantas hora:\n");
	scanf (" %f",&hora);
	
	printf ("minuto (m/M) ou segundo (s/S) :\n");
	scanf (" %c",&what);

	switch(what)
	
		{
		case 'm':
		case 'M': printf ("%.f hora sao \n%.f minuto\n", hora, hora*minuto); break;
		
		case 's':
		case 'S': printf ("%.f hora sao \n%.f segundo\n", hora, hora*segundo); break;
		}
		
	printf ("%.f hora sao \n%.f minuto\n", hora, hora*minuto);
	printf ("%.f hora sao \n%.f segundo\n", hora, hora*segundo);

}