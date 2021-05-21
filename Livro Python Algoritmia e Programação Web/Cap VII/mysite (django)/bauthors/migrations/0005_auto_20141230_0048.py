# -*- coding: utf-8 -*-
from __future__ import unicode_literals

from django.db import models, migrations


class Migration(migrations.Migration):

    dependencies = [
        ('bauthors', '0004_auto_20141229_2338'),
    ]

    operations = [
        migrations.AlterModelOptions(
            name='competencia',
            options={'verbose_name': 'Competencia', 'verbose_name_plural': 'Competencias'},
        ),
        migrations.AlterModelOptions(
            name='livro',
            options={'verbose_name': 'Livro', 'verbose_name_plural': 'Livros'},
        ),
        migrations.AlterField(
            model_name='livro',
            name='data',
            field=models.DateField(blank=True, null=True),
            preserve_default=True,
        ),
    ]
