from django.db import models

# bauthors models

class Editora(models.Model):
    editora = models.CharField(max_length=35)
    email = models.EmailField()
    url = models.URLField(blank=True)
    acronym = models.CharField(max_length=25)
    author = models.CharField(max_length=50, null=True)
    
    class Meta:
        verbose_name_plural = 'Editoras'
        verbose_name = 'Editora'

    def __str__(self):
        return self.editora
    
class Competencia(models.Model):
    competencia = models.CharField(max_length=45)
    resumo = models.CharField(max_length=150)
    acronym = models.CharField(max_length=25)
    author = models.CharField(max_length=50, null=True)

    class Meta:
        verbose_name_plural = 'Competencias'
        verbose_name = 'Competencia'

    def __str__(self):
        return self.competencia

class Autor(models.Model):
    nome = models.CharField(max_length=50)
    perfil = models.CharField(max_length=50)
    email = models.EmailField()
    competencias = models.ManyToManyField(Competencia,verbose_name='Competencia')
    acronym = models.CharField(max_length=25)
    author = models.CharField(max_length=50, null=True)

    class Meta:
        verbose_name_plural = 'Autores'
        verbose_name = 'Autor'

    def __str__(self):
        return self.nome

class Livro(models.Model):
    titulo = models.CharField(max_length=50)
    resumo = models.CharField(max_length=150)
    data = models.DateField(null=True, blank=True, )
    edicao = models.IntegerField(default=1)
    exemplares = models.IntegerField(default=750)
    editora = models.ForeignKey(Editora)
    autores = models.ManyToManyField(Autor,verbose_name='Autor')
    acronym = models.CharField(max_length=25)
    author = models.CharField(max_length=50, null=True)

    class Meta:
        verbose_name_plural = 'Livros'
        verbose_name = 'Livro'

    def __str__(self):
        return self.titulo


