# -*- coding: utf-8 -*-
from __future__ import unicode_literals

from django.db import models, migrations
import datetime
from django.utils.timezone import utc


class Migration(migrations.Migration):

    dependencies = [
        ('bauthors', '0002_auto_20141229_2251'),
    ]

    operations = [
        migrations.AddField(
            model_name='autor',
            name='acronym',
            field=models.CharField(max_length=25, default=datetime.datetime(2014, 12, 29, 23, 23, 42, 741585, tzinfo=utc)),
            preserve_default=False,
        ),
        migrations.AddField(
            model_name='autor',
            name='author',
            field=models.CharField(null=True, max_length=50),
            preserve_default=True,
        ),
        migrations.AddField(
            model_name='competencia',
            name='acronym',
            field=models.CharField(max_length=25, default=datetime.datetime(2014, 12, 29, 23, 23, 59, 82673, tzinfo=utc)),
            preserve_default=False,
        ),
        migrations.AddField(
            model_name='competencia',
            name='author',
            field=models.CharField(null=True, max_length=50),
            preserve_default=True,
        ),
        migrations.AddField(
            model_name='editora',
            name='acronym',
            field=models.CharField(max_length=25, default=datetime.datetime(2014, 12, 29, 23, 24, 12, 438600, tzinfo=utc)),
            preserve_default=False,
        ),
        migrations.AddField(
            model_name='editora',
            name='author',
            field=models.CharField(null=True, max_length=50),
            preserve_default=True,
        ),
        migrations.AddField(
            model_name='livro',
            name='acronym',
            field=models.CharField(max_length=25, default=datetime.datetime(2014, 12, 29, 23, 24, 43, 277483, tzinfo=utc)),
            preserve_default=False,
        ),
        migrations.AddField(
            model_name='livro',
            name='author',
            field=models.CharField(null=True, max_length=50),
            preserve_default=True,
        ),
    ]
