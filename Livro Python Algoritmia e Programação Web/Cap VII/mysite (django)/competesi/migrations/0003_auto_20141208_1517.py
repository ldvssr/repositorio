# -*- coding: utf-8 -*-
from __future__ import unicode_literals

from django.db import models, migrations


class Migration(migrations.Migration):

    dependencies = [
        ('competesi', '0002_auto_20141208_1221'),
    ]

    operations = [
        migrations.RemoveField(
            model_name='competencia',
            name='evidencia',
        ),
        migrations.RemoveField(
            model_name='taxionomia',
            name='subcomp',
        ),
        migrations.AddField(
            model_name='taxionomia',
            name='competencias',
            field=models.ManyToManyField(verbose_name='Competências', to='competesi.Competencia'),
            preserve_default=True,
        ),
        migrations.AlterField(
            model_name='competencia',
            name='designacao',
            field=models.CharField(max_length=75),
            preserve_default=True,
        ),
    ]
