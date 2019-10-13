// Link to kata: https://www.codewars.com/kata/scramblies/

#include <stdbool.h>
#include <stdio.h>

bool scramble(const char *str1, const char *str2)
{
    int hash[26] = {0};

    for (char *c = str1; *c; c++)
        hash[*c - 'a']++;

    for (char *c = str2; *c; c++)
    {
        hash[*c - 'a']--;
        if (hash[*c - 'a'] < 0)
            return false;
    }

    return true;
}