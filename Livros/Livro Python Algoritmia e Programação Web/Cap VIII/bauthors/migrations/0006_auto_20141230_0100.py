# -*- coding: utf-8 -*-
from __future__ import unicode_literals

from django.db import models, migrations


class Migration(migrations.Migration):

    dependencies = [
        ('bauthors', '0005_auto_20141230_0048'),
    ]

    operations = [
        migrations.RenameField(
            model_name='competencia',
            old_name='acompetencia',
            new_name='competencia',
        ),
    ]
