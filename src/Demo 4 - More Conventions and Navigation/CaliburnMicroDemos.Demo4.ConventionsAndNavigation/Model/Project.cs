namespace CaliburnMicroDemos.Demo4.ConventionsAndNavigation.Model
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