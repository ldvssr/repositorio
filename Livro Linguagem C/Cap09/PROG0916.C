#include <stdio.h>

main(int argc, char** argv, char **env)
{
	while (*env)
    puts(*env++);
}
