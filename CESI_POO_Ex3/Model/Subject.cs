namespace CESI_POO_Ex3.Model
{
    public class Subject
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Subject(string name, string description)
        {
            Name = name;
            Description = description;
        }

        public override string ToString()
        {
            return "\n\t" + "Name : " + Name
                + "\n\t" + "Description : " + Description;
        }
    }
}