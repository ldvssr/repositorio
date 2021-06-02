
from bauthors.models import Editora, Competencia, Autor, Livro
from django.contrib import admin
from django import forms
from django.forms import ModelForm, Textarea
from datetime import datetime

# editora
class EditoraAdmin(admin.ModelAdmin):
    fields = ( 'editora', 'email', 'url', )
    list_display = ( 'editora', 'email', 'url', )
    list_filter = ( 'editora', )
    search_fields = ( 'editora', 'email',)
    ordering = ( 'editora', )
    def save_model(self, request, obj, form, change):
        obj.author = request.user.username
        obj.acronym = obj.acronym.upper()
        super(EditoraAdmin, self).save_model(request, obj, form, change)

# competencia
class CompAdmin(admin.ModelAdmin):
    fields = ( 'competencia', 'resumo', )
    list_display = ( 'competencia', 'resumo', )
    list_filter = ( 'competencia', )
    search_fields = ( 'competencia', )
    ordering = ( 'competencia', )
    def save_model(self, request, obj, form, change):
        obj.author = request.user.username
        obj.acronym = obj.acronym.upper()
        super(CompAdmin, self).save_model(request, obj, form, change)

# Autor
class AutorAdmin(admin.ModelAdmin):
    fields = ( 'nome', 'perfil', 'email', 'competencias', )
    filter_horizontal = ( 'competencias', )
    list_display = ( 'nome', 'perfil', 'email', )
    list_filter = ( 'nome', )
    search_fields = ( 'nome', )
    ordering = ( 'nome', )
    def save_model(self, request, obj, form, change):
        obj.author = request.user.username
        obj.acronym = obj.acronym.upper()
        super(AutorAdmin, self).save_model(request, obj, form, change)

# Livro
class LivroAdmin(admin.ModelAdmin):
    fields = ( 'titulo','resumo', 'data','edicao','exemplares','editora','autores',)
    filter_horizontal = ( 'autores', )
    list_display = ( 'titulo', 'resumo', 'data','edicao','exemplares',)
    list_filter = ( 'editora', 'autores',)
    search_fields = ( 'titulo', 'data', 'autores', )
    ordering = ( 'titulo', )
    def save_model(self, request, obj, form, change):
        obj.author = request.user.username
        obj.acronym = obj.acronym.upper()
        super(LivroAdmin, self).save_model(request, obj, form, change)
    
# Register your models here

admin.site.register(Editora, EditoraAdmin)
admin.site.register(Competencia, CompAdmin)
admin.site.register(Autor, AutorAdmin)
admin.site.register(Livro, LivroAdmin)
