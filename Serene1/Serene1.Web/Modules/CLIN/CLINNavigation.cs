using Serenity.Navigation;
using MyPages = Serene1.CLIN.Pages;

[assembly: NavigationLink(int.MaxValue, "CLIN/Estados", typeof(MyPages.EstadosController), icon: null)]
[assembly: NavigationLink(int.MaxValue, "CLIN/Profesiones", typeof(MyPages.ProfesionesController), icon: null)]
[assembly: NavigationLink(int.MaxValue, "CLIN/Grupos", typeof(MyPages.GruposController), icon: null)]
[assembly: NavigationLink(int.MaxValue, "CLIN/App Campos", typeof(MyPages.AppCamposController), icon: null)]
[assembly: NavigationLink(int.MaxValue, "CLIN/App Formulario", typeof(MyPages.AppFormularioController), icon: null)]