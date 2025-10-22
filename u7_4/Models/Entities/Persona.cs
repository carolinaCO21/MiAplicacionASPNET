namespace u7_4.Models.Entities
{
    public class Persona
    {

        public int Id { get; init; }


        public string Name { get; set; }
        public string Surname { get; set; }




        public Persona(int id, string name, string surname)
        {
            this.Id = id;
            this.Name = name;
            this.Surname = surname;
        }
    }
}
