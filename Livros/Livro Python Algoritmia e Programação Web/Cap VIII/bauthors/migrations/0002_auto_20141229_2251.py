# -*- coding: utf-8 -*-
from __future__ import unicode_literals

from django.db import models, migrations


class Migration(migrations.Migration):

    dependencies = [
        ('bauthors', '0001_initial'),
    ]

    operations = [
        migrations.CreateModel(
            name='Autor',
            fields=[
                ('id', models.AutoField(auto_created=True, primary_key=True, serialize=False, verbose_name='ID')),
                ('nome', models.CharField(max_length=50)),
                ('perfil', models.CharField(max_length=50)),
                ('email', models.EmailField(max_length=254)),
            ],
            options={
                'verbose_name': 'Autor',
                'verbose_name_plural': 'Autores',
            },
            bases=(models.Model,),
        ),
        migrations.CreateModel(
            name='Livro',
            fields=[
                ('id', models.AutoField(auto_created=True, primary_key=True, serialize=False, verbose_name='ID')),
                ('titulo', models.CharField(max_length=50)),
                ('resumo', models.CharField(max_length=150)),
                ('data_pub', models.DateField(verbose_name='Data de publicação', auto_now_add=True)),
                ('edicao', models.IntegerField(default=1)),
                ('exemplares', models.IntegerField(default=750)),
                ('autores', models.ManyToManyField(to='bauthors.Autor', verbose_name='Autor')),
            ],
            options={
                'verbose_name': 'Competencia',
                'verbose_name_plural': 'Competencias',
            },
            bases=(models.Model,),
        ),
        migrations.RenameModel(
            old_name='Competencias',
            new_name='Competencia',
        ),
        migrations.RenameModel(
            old_name='Editoras',
            new_name='Editora',
        ),
        migrations.RemoveField(
            model_name='autores',
            name='competencia',
        ),
        migrations.RemoveField(
            model_name='livros',
            name='autores',
        ),
        migrations.DeleteModel(
            name='Autores',
        ),
        migrations.RemoveField(
            model_name='livros',
            name='editora',
        ),
        migrations.DeleteModel(
            name='Livros',
        ),
        migrations.AddField(
            model_name='livro',
            name='editora',
            field=models.ForeignKey(to='bauthors.Editora'),
            preserve_default=True,
        ),
        migrations.AddField(
            model_name='autor',
            name='competencias',
            field=models.ManyToManyField(to='bauthors.Competencia', verbose_name='Competencia'),
            preserve_default=True,
        ),
        migrations.AlterModelOptions(
            name='competencia',
            options={'verbose_name_plural': 'Comptencias', 'verbose_name': 'Competencia'},
        ),
        migrations.AlterModelOptions(
            name='editora',
            options={'verbose_name_plural': 'Editoras', 'verbose_name': 'Editora'},
        ),
    ]
