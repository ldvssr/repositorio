# -*- coding: utf-8 -*-
from __future__ import unicode_literals

from django.db import models, migrations
import datetime
from django.utils.timezone import utc


class Migration(migrations.Migration):

    dependencies = [
        ('bauthors', '0003_auto_20141229_2325'),
    ]

    operations = [
        migrations.RemoveField(
            model_name='livro',
            name='data_pub',
        ),
        migrations.AddField(
            model_name='livro',
            name='data',
            field=models.DateField(default=datetime.datetime(2014, 12, 29, 23, 38, 6, 209846, tzinfo=utc), auto_now_add=True),
            preserve_default=False,
        ),
    ]
