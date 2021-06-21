# libraries

from django.contrib import admin
from competesi.models import AreaAp, Bibliografia, Competencia, Evidencia, Funcionario, Projeto, Taxionomia
from django.contrib import admin
from django import forms
from django.forms import ModelForm, Textarea
from datetime import datetime

# register the models.

admin.site.register(AreaAp)
admin.site.register(Bibliografia)
admin.site.register(Competencia)
admin.site.register(Evidencia)
admin.site.register(Funcionario)
admin.site.register(Projeto)
admin.site.register(Taxionomia)
