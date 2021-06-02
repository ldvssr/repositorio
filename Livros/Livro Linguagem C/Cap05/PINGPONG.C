void Ping(int i)
{
switch (i)
  {
    case 1:
    case 2:
    case 3:  while (i--)
               printf("\n%d",--i);
             break;
    case 25: Pong(3);
             break;
    default: printf("\nJa Passei a C");
             Pong(123);
  }
}

void Pong(int x)
{
int j=0;
switch (x)
  {
   case 1:
   case 2: Ping(x);
   case 3: j=5;
           j++;
           return;
  default: printf("\nOla");
           return;
  }
printf("\nVou Sair");
}
