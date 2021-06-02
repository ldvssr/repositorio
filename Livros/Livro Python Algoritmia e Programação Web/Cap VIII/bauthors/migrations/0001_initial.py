# -*- coding: utf-8 -*-
from __future__ import unicode_literals

from django.db import models, migrations


class Migration(migrations.Migration):

    dependencies = [
    ]

    operations = [
        migrations.CreateModel(
            name='Autores',
            fields=[
                ('id', models.AutoField(primary_key=True, verbose_name='ID', serialize=False, auto_created=True)),
                ('nome', models.CharField(max_length=50)),
                ('email', models.EmailField(max_length=254)),
                ('telef', models.CharField(max_length=25)),
            ],
            options={
            },
            bases=(models.Model,),
        ),
        migrations.CreateModel(
            name='Competencias',
            fields=[
                ('id', models.AutoField(primary_key=True, verbose_name='ID', serialize=False, auto_created=True)),
                ('acompetencia', models.CharField(max_length=45)),
                ('resumo', models.CharField(max_length=150)),
            ],
            options={
            },
            bases=(models.Model,),
        ),
        migrations.CreateModel(
            name='Editoras',
            fields=[
                ('id', models.AutoField(primary_key=True, verbose_name='ID', serialize=False, auto_created=True)),
                ('editora', models.CharField(max_length=35)),
                ('email', models.EmailField(max_length=254)),
                ('url', models.URLField(blank=True)),
            ],
            options={
            },
            bases=(models.Model,),
        ),
        migrations.CreateModel(
            name='Livros',
            fields=[
                ('id', models.AutoField(primary_key=True, verbose_name='ID', serialize=False, auto_created=True)),
                ('titulo', models.CharField(max_length=50)),
                ('resumo', models.CharField(max_length=150)),
                ('data_pub', models.DateTimeField()),
                ('edicao', models.IntegerField(default=1)),
                ('exemplares', models.IntegerField(default=750)),
                ('autores', models.ManyToManyField(verbose_name='Autores', to='bauthors.Autores')),
                ('editora', models.ForeignKey(to='bauthors.Editoras')),
            ],
            options={
            },
            bases=(models.Model,),
        ),
        migrations.AddField(
            model_name='autores',
            name='competencia',
            field=models.ForeignKey(to='bauthors.Competencias'),
            preserve_default=True,
        ),
    ]
