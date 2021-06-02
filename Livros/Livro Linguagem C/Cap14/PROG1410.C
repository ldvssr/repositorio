 #include <stdio.h>

/* Mostra o conteudo de um Byte em Bits */
void Mostra_Byte(unsigned char ch)
{ int i;
  for (i=7;i>=0;i--)
	 printf("%d",(ch >>i) & 1);
}

main()
{
	unsigned char ch = 0;
	int i;
	for (i=0;i<8;i++)
	  { ch = ch + (1<<i);
		 Mostra_Byte(ch);
		 printf("\t%d\n",ch );
	  }

}
