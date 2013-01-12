namespace CaliburnMicroDemos.Demo4.ConventionsAndNavigationComplete.Model
{
    public class Project
    {
        public override string ToString()
        {
            return Name;
        }

        public string Id { get; set; }
        public string Name { get; set; }
    }
}