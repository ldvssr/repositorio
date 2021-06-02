void tiro(int x)
{
  switch(x)
    {
      case 1: printf("\nEste teste e mesmo facil");
      case 2: printf("\nAi de quem diga o contrario...");
              return;
      case 3: printf("\nEstou no Tiro e x = %d",x);
              liro(x++);
              break;
              printf("\nVou sair do tiro");
     default: printf("\nEntrei pelo default");
              liro(x);
     }
}


void liro(int x)
{
  switch(x)
    {
      case 2: return;
              printf("\nOlarailarilolela");
              break;
      case 3: printf("\nEu percebo HIMALAIAS de C");
              break;
              printf("\nSou mesmo Bom!!!");
              break;
      case 4: printf("\nNão percebo nada disto");
              liro(2);
              return;
     default: printf("\nCá estou eu mais uma vez");
              tiro(x--);
    }
}
