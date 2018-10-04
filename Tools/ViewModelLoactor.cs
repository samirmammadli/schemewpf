using Autofac;
using SchemeWpf.Navigation;
using SchemeWpf.Services;
using SchemeWpf.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchemeWpf.Tools
{
    class ViewModelLoactor
    {
        public IContainer Container { get; set; }
        NavigationService navigationService = new NavigationService();
        NavigationServiceInternal navigationServiceInternal = new NavigationServiceInternal();

        public LoadingViewModel LoadingViewModel { get; }
        public MainViewModel MainViewModel { get; }
        public MainNavigationViewModel MainNavigationViewModel { get; }
        public LoginViewModel LoginViewModel { get; }
        public SignUpViewModel SignUpViewModel { get; }
        public RegistrationConfirmCodeViewModel RegistrationConfirmCodeViewModel { get; }
        public Repo MyRepo { get; set; }
        public NavigationServiceInternal InternalNavigationService { get; set; }
        public ProjectsListViewModel ProjectsListViewModel { get; }
        public BoardViewModel BoardViewModel { get; set; }
        public ProjectConfigurationViewModel ProjectConfigurationView { get; set; }
        public NotificationsViewModel NotificationsViewModel { get; set; }
        public ForgotPasswordViewModel ForgotPasswordViewModel { get; set; }
        public EmailEnterViewModel EmailEnterViewModel { get; set; }

        public ViewModelLoactor()
        {
            try
            {
                var builder = new ContainerBuilder();
                //builder.RegisterType<MoviesRepository>().As<IMoviesRepository>().InstancePerLifetimeScope();
                builder.RegisterType<MainViewModel>();
                builder.RegisterType<MainNavigationViewModel>();
                builder.RegisterType<LoginViewModel>();
                builder.RegisterType<LoadingViewModel>().SingleInstance();
                builder.RegisterType<MessageBoxViewModel>().SingleInstance();
                builder.RegisterType<RegistrationConfirmCodeViewModel>();
                builder.RegisterType<SignUpViewModel>();
                builder.RegisterType<Repo>();
                builder.RegisterType<NavigationServiceInternal>().SingleInstance();
                builder.RegisterInstance(navigationService).SingleInstance();
                builder.RegisterInstance(navigationServiceInternal).SingleInstance();
                builder.RegisterType<BoardViewModel>();
                builder.RegisterType<ProjectConfigurationViewModel>();
                builder.RegisterType<ProjectsListViewModel>();
                builder.RegisterType<NotificationsViewModel>();
                builder.RegisterType<ForgotPasswordViewModel>();
                builder.RegisterType<EmailEnterViewModel>();
                builder.RegisterType<LoginResponseHandler>().SingleInstance();
                builder.RegisterType<SignUpResponseHandler>().SingleInstance();
                Container = builder.Build();

                using (var scope = Container.BeginLifetimeScope())
                {
                    MainViewModel = scope.Resolve<MainViewModel>();
                    MainNavigationViewModel = scope.Resolve<MainNavigationViewModel>();
                    LoadingViewModel = scope.Resolve<LoadingViewModel>();
                    LoginViewModel = scope.Resolve<LoginViewModel>();
                    RegistrationConfirmCodeViewModel = scope.Resolve<RegistrationConfirmCodeViewModel>();
                    SignUpViewModel = scope.Resolve<SignUpViewModel>();
                    MyRepo = scope.Resolve<Repo>();
                    InternalNavigationService = scope.Resolve<NavigationServiceInternal>();
                    BoardViewModel = scope.Resolve<BoardViewModel>();
                    ProjectConfigurationView = scope.Resolve<ProjectConfigurationViewModel>();
                    NotificationsViewModel = scope.Resolve<NotificationsViewModel>(); 
                    ProjectsListViewModel = scope.Resolve<ProjectsListViewModel>();
                    ForgotPasswordViewModel = scope.Resolve<ForgotPasswordViewModel>();
                    EmailEnterViewModel = scope.Resolve<EmailEnterViewModel>();
                }

                navigationService.AddPage(LoginViewModel, VM.LoginViewModel);
                navigationService.AddPage(MainNavigationViewModel, VM.MainNavigationViewModel);
                navigationService.AddPage(SignUpViewModel, VM.SignUpViewModel);
                navigationService.AddPage(RegistrationConfirmCodeViewModel, VM.RegistrationConfirmCodeViewModel);
                navigationService.AddPage(ForgotPasswordViewModel, VM.ForgotPasswordViewModel);
                navigationService.AddPage(EmailEnterViewModel, VM.EmailEnterViewModel);

                navigationService.NavigateTo(VM.LoginViewModel);

                navigationServiceInternal.AddPage(ProjectsListViewModel, VM.ProjectsListViewModel);
                navigationServiceInternal.AddPage(BoardViewModel, VM.BoardViewModel);
                navigationServiceInternal.AddPage(ProjectConfigurationView, VM.ProjectConfigurationView);
                navigationServiceInternal.AddPage(NotificationsViewModel, VM.NotificationsViewModel);

                navigationServiceInternal.NavigateTo(VM.ProjectsListViewModel);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
