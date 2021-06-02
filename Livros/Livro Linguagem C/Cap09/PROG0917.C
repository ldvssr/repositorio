#include <stdio.h>
#include <string.h>

main(int argc, char** argv, char **env)
{
	while (*env)
		puts(strchr(*env++,'=')+1);
}
