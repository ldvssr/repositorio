void *calloc(size_t num , size_t size)
{
  void * tmp;
  tmp = malloc(num*size);
  if (tmp!=NULL) 
    memset(tmp,'\0',num*size);
  return tmp;
}
