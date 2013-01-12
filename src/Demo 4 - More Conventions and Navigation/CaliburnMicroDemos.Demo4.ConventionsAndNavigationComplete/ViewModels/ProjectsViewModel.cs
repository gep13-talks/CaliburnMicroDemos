namespace CaliburnMicroDemos.Demo4.ConventionsAndNavigationComplete.ViewModels
{
    using System.Windows;
    using Caliburn.Micro;
    using CaliburnMicroDemos.Demo4.ConventionsAndNavigationComplete.Model;

    public class ProjectsViewModel : PropertyChangedBase
    {
        private BindableCollection<Project> projects;
        private Project selectedProject;

        public ProjectsViewModel()
        {
            this.GetProjects();
        }

        public BindableCollection<Project> Projects
        {
            get { return projects; }
            set
            {
                projects = value;
                NotifyOfPropertyChange(() => Projects);
            }
        }

        public Project SelectedProject
        {
            get { return selectedProject; }
            set
            {
                selectedProject = value;
                NotifyOfPropertyChange(() => SelectedProject);
                if (selectedProject != null)
                {
                    MessageBox.Show(
                        string.Format("The selected project is {0}", selectedProject.Name));
                }
            }
        }

        private void GetProjects()
        {
            this.Projects = new BindableCollection<Project>()
                {
                    new Project()
                        {
                            Id = "1",Name = "Project 1"
                        },
                    new Project()
                        {
                            Id = "2", Name = "Project 2"
                        },
                    new Project()
                        {
                            Id = "3", Name = "Project 3"
                        },
                    new Project()
                        {
                            Id = "4", Name = "Project 4"
                        }
                };
        }
    }
}