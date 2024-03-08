using System.Security.Cryptography.X509Certificates;

namespace TugasMandiri1.Models
{
    public class PersonContext
    {
        public List<Person> ListPerson()
        {
            List<Person> listPerson = new List<Person>();
            Object[,] arrayPerson = new Object[,]{
                {1, "Firdha", "Jl. Baturaden 14", "firdhaac02@gmail.com" },
                {2, "Takumi", "Jl. Tokyo 8", "takumi84@gmail.com" },
                {3, "Jinman", "Jl. Soul 43", "mutherhelp@gmail.com" }
            };
            for (int i = 0; i < arrayPerson.GetLength(0); i++)
            {
                listPerson.Add(new Person()
                {
                    id_person = int.Parse(arrayPerson[i, 0].ToString()),
                    nama = arrayPerson[i, 1].ToString(),
                    alamat = arrayPerson[i, 2].ToString(),
                    email = arrayPerson[i, 3].ToString()
                });
            }
            return listPerson;

        }
        public Person GetPerson(int id_person)
        {
            return ListPerson().Find(x => x.id_person == id_person);
        }

    }
}
