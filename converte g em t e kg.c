#include <stdio.h>

int main() {
    float f1;
    float f2 = 1000;
    float tonelada;
    float grama;
    printf("quilograma?\n");
    scanf("%f",&f1);
    tonelada = f1 / f2;
    grama = f1 * f2;

    printf("%.f quilograma = %.4f tonelada\n",f1, tonelada);
    printf("%.f quilograma = %.4f grama\n",f1, grama);

    return 0;
}