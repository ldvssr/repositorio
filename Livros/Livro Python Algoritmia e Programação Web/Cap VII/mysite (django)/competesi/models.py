import datetime
from django.db import models
from django.utils import timezone

# models for competesi app

# Evidencia

class Evidencia(models.Model):
    designacao = models.CharField(max_length=50)
    descricao = models.TextField(null=True, blank=True,)
    tipo = models.CharField(max_length=30)

    class Meta:
        verbose_name_plural = 'Evidencias'
        verbose_name = 'Evidencia'

    def __unicode__(self):
        return self.nome

# Competencia 

class Competencia(models.Model):
    designacao = models.CharField(max_length=75)
    descricao = models.TextField(null=True, blank=True,)

    class Meta:
        verbose_name_plural = 'Competencias'
        verbose_name = 'Competencia'

    def __unicode__(self):
        return self.nome

# Referências bibliográficas

class Bibliografia(models.Model):
    ref = models.CharField(max_length=30)
    titulo = models.CharField(max_length=75)
    tipo = models.CharField(max_length=50)
    anopub = models.IntegerField(max_length=4)
    ref_completa = models.CharField(max_length=250)
    url = models.CharField(max_length=100)

    class Meta:
        verbose_name_plural = 'Referências bibliográficas'
        verbose_name = 'Bibliografia'

    def __unicode__(self):
        return self.nome

# Areas de aplicação

class AreaAp(models.Model):
    designacao = models.CharField(max_length=50)
    descricao = models.TextField(null=True, blank=True,)
    refs = models.ManyToManyField(Bibliografia,verbose_name='Area',)

    class Meta:
        verbose_name_plural = 'Areas de aplicação'
        verbose_name = 'Area de aplicação'

    def __unicode__(self):
        return self.nome


# Taxionomia de competências

class Taxionomia(models.Model):
    txcompete = models.CharField(max_length=35)
    descricao = models.TextField(null=True, blank=True,)
    superCompetencia = models.ForeignKey(Competencia)
    #competencias = models.ManyToManyField(Competencia,verbose_name='Competências',)
    areas = models.ManyToManyField(AreaAp,verbose_name='Areas de aplicação',)

    class Meta:
        verbose_name_plural = 'Taxonomia de Competências'
        verbose_name = 'TxCompetencias'

    def __unicode__(self):
        return self.nome

# Funcionario

class Funcionario(models.Model):
    codfunc = models.IntegerField(max_length=5, verbose_name='Cod. Funcionário')
    nome = models.CharField(max_length=50)
    funcao = models.CharField(max_length=50)
    dtcontrato = models.DateTimeField(auto_now=False, auto_now_add=True)
    competencias = models.ManyToManyField(Competencia,verbose_name='Competecias',)
    evidencias = models.ManyToManyField(Evidencia,verbose_name='Evidências',)

    class Meta:
        verbose_name_plural = 'Funcionarios'
        verbose_name = 'Funcionario'

    def __unicode__(self):
        return self.nome

# Projeto

class Projeto(models.Model):
    codpro = models.CharField(max_length=5)
    nome = models.CharField(max_length=50)
    descricao = models.TextField(null=True, blank=True,)
    d_inicio = models.DateTimeField(auto_now=False, auto_now_add=True)
    d_conclusao = models.DateTimeField(auto_now=False, auto_now_add=True)
    funcionarios = models.ManyToManyField(Funcionario,verbose_name='Funcionarios',)

    class Meta:
        verbose_name_plural = 'Projetos'
        verbose_name = 'Projeto'

    def __unicode__(self):
        return self.nome




