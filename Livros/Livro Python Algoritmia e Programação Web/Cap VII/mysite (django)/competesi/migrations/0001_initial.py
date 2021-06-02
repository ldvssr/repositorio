# -*- coding: utf-8 -*-
from __future__ import unicode_literals

from django.db import models, migrations


class Migration(migrations.Migration):

    dependencies = [
    ]

    operations = [
        migrations.CreateModel(
            name='AreaAp',
            fields=[
                ('id', models.AutoField(primary_key=True, verbose_name='ID', auto_created=True, serialize=False)),
                ('designacao', models.CharField(max_length=50)),
                ('descricao', models.CharField(max_length=150)),
                ('acronym', models.CharField(max_length=20)),
                ('created_at', models.DateTimeField(verbose_name='Created', auto_now_add=True)),
                ('updated_at', models.DateTimeField(verbose_name='Changed', auto_now=True)),
                ('expire_at', models.DateTimeField(verbose_name='Expires', null=True)),
                ('author', models.CharField(max_length=40, null=True)),
            ],
            options={
                'verbose_name': 'Area de aplicação',
                'verbose_name_plural': 'Areas de aplicação',
            },
            bases=(models.Model,),
        ),
        migrations.CreateModel(
            name='Bibliografia',
            fields=[
                ('id', models.AutoField(primary_key=True, verbose_name='ID', auto_created=True, serialize=False)),
                ('ref', models.CharField(max_length=30)),
                ('titulo', models.CharField(max_length=75)),
                ('tipo', models.CharField(max_length=50)),
                ('anopub', models.IntegerField(max_length=4)),
                ('ref_completa', models.CharField(max_length=250)),
                ('url', models.CharField(max_length=100)),
                ('acronym', models.CharField(max_length=20)),
                ('created_at', models.DateTimeField(verbose_name='Created', auto_now_add=True)),
                ('updated_at', models.DateTimeField(verbose_name='Changed', auto_now=True)),
                ('expire_at', models.DateTimeField(verbose_name='Expires', null=True)),
                ('author', models.CharField(max_length=40, null=True)),
            ],
            options={
                'verbose_name': 'Bibliografia',
                'verbose_name_plural': 'Referências bibliográficas',
            },
            bases=(models.Model,),
        ),
        migrations.CreateModel(
            name='Competencia',
            fields=[
                ('id', models.AutoField(primary_key=True, verbose_name='ID', auto_created=True, serialize=False)),
                ('designacao', models.CharField(max_length=50)),
                ('descricao', models.TextField(blank=True, null=True)),
                ('acronym', models.CharField(max_length=15)),
                ('created_at', models.DateTimeField(verbose_name='Created', auto_now_add=True)),
                ('updated_at', models.DateTimeField(verbose_name='Changed', auto_now=True)),
                ('expire_at', models.DateTimeField(verbose_name='Expires', null=True)),
                ('author', models.CharField(max_length=40, null=True)),
            ],
            options={
                'verbose_name': 'Competencia',
                'verbose_name_plural': 'Competencias',
            },
            bases=(models.Model,),
        ),
        migrations.CreateModel(
            name='Evidencia',
            fields=[
                ('id', models.AutoField(primary_key=True, verbose_name='ID', auto_created=True, serialize=False)),
                ('designacao', models.CharField(max_length=50)),
                ('descricao', models.TextField(blank=True, null=True)),
                ('tipo', models.CharField(max_length=30)),
                ('acronym', models.CharField(max_length=15)),
                ('created_at', models.DateTimeField(verbose_name='Created', auto_now_add=True)),
                ('updated_at', models.DateTimeField(verbose_name='Changed', auto_now=True)),
                ('expire_at', models.DateTimeField(verbose_name='Expires', null=True)),
                ('author', models.CharField(max_length=40, null=True)),
            ],
            options={
                'verbose_name': 'Evidencia',
                'verbose_name_plural': 'Evidencias',
            },
            bases=(models.Model,),
        ),
        migrations.CreateModel(
            name='Funcionario',
            fields=[
                ('id', models.AutoField(primary_key=True, verbose_name='ID', auto_created=True, serialize=False)),
                ('codf', models.IntegerField(max_length=5)),
                ('nome', models.CharField(max_length=50)),
                ('funcao', models.CharField(max_length=50)),
                ('dtcontrato', models.DateTimeField(auto_now_add=True)),
                ('created_at', models.DateTimeField(verbose_name='Created', auto_now_add=True)),
                ('updated_at', models.DateTimeField(verbose_name='Changed', auto_now=True)),
                ('expire_at', models.DateTimeField(verbose_name='Expires', null=True)),
                ('author', models.CharField(max_length=40, null=True)),
                ('competencias', models.ManyToManyField(verbose_name='Competecias', to='competesi.Competencia')),
                ('evidencias', models.ManyToManyField(verbose_name='Evidências', to='competesi.Evidencia')),
            ],
            options={
                'verbose_name': 'Funcionario',
                'verbose_name_plural': 'Funcionarios',
            },
            bases=(models.Model,),
        ),
        migrations.CreateModel(
            name='Projeto',
            fields=[
                ('id', models.AutoField(primary_key=True, verbose_name='ID', auto_created=True, serialize=False)),
                ('codpro', models.CharField(max_length=5)),
                ('nome', models.CharField(max_length=50)),
                ('descricao', models.TextField(blank=True, null=True)),
                ('d_inicio', models.DateTimeField(auto_now_add=True)),
                ('d_conclusao', models.DateTimeField(auto_now_add=True)),
                ('acronym', models.CharField(max_length=20)),
                ('created_at', models.DateTimeField(verbose_name='Created', auto_now_add=True)),
                ('updated_at', models.DateTimeField(verbose_name='Changed', auto_now=True)),
                ('expire_at', models.DateTimeField(verbose_name='Expires', null=True)),
                ('author', models.CharField(max_length=40, null=True)),
                ('funcionarios', models.ManyToManyField(verbose_name='Funcionarios', to='competesi.Funcionario')),
            ],
            options={
                'verbose_name': 'Projeto',
                'verbose_name_plural': 'Projetos',
            },
            bases=(models.Model,),
        ),
        migrations.CreateModel(
            name='Taxionomia',
            fields=[
                ('id', models.AutoField(primary_key=True, verbose_name='ID', auto_created=True, serialize=False)),
                ('txcompete', models.CharField(max_length=35)),
                ('descricao', models.TextField(blank=True, null=True)),
                ('acronym', models.CharField(max_length=15)),
                ('created_at', models.DateTimeField(verbose_name='Created', auto_now_add=True)),
                ('updated_at', models.DateTimeField(verbose_name='Changed', auto_now=True)),
                ('expire_at', models.DateTimeField(verbose_name='Expires', null=True)),
                ('author', models.CharField(max_length=40, null=True)),
                ('areas', models.ManyToManyField(verbose_name='Areas de aplicação', to='competesi.AreaAp')),
                ('competencias', models.ManyToManyField(verbose_name='Competencias', to='competesi.Competencia')),
            ],
            options={
                'verbose_name': 'TxCompetencias',
                'verbose_name_plural': 'Taxonomia de Competências',
            },
            bases=(models.Model,),
        ),
        migrations.AddField(
            model_name='competencia',
            name='evidencia',
            field=models.ManyToManyField(verbose_name='Evidencia', to='competesi.Evidencia'),
            preserve_default=True,
        ),
        migrations.AddField(
            model_name='areaap',
            name='refs',
            field=models.ManyToManyField(verbose_name='Area', to='competesi.Bibliografia'),
            preserve_default=True,
        ),
    ]
