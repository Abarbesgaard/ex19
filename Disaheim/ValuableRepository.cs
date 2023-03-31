using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;


namespace Disaheim
{
    public class ValuableRepository : IPersistable
    {
        private List<IValuable> valuables = new List<IValuable>();

        public void AddValuable(IValuable valuable)
        {
            valuables.Add(valuable);
        }
        public IValuable GetValuable(string id)
        {
            foreach (IValuable valuable in valuables)
            {
                if (valuable is Merchandise && (valuable as Merchandise).ItemId == id)
                    return valuable;
                else if (valuable is Course && (valuable as Course).Name == id)
                    return valuable;
            }
            return null;
        }
        public double GetTotalValue()
        {
            double total = 0;


            foreach (IValuable valuable in valuables)
            {
                total += valuable.GetValue();
            }

            return total;
        }
        public int Count()
        {
            int x = valuables.Count;
            return x;
        }
        
        public void Save(string filename = "ValuableRepository.txt")
        {
            StreamWriter sr = new StreamWriter(filename);

            foreach (IValuable valuable in valuables)
            {
                
                if (valuable is Book)
                {
                    Book sauce = (Book)valuable;
                    sr.WriteLine($"BOG;{sauce.ItemId};{sauce.Title};{sauce.GetValue()}");
                }
                else if (valuable is Amulet)
                {
                    Amulet sauce = (Amulet)valuable;
                    sr.WriteLine($"AMULET;{sauce.ItemId};{sauce.Quality};{sauce.Design}");
                }
                else if (valuable is Course)
                {
                    Course sauce = (Course)valuable;
                    sr.WriteLine($"KURSUS;{sauce.Name};{sauce.DurationInMinutes};{Course.CourseHourValue};{sauce.GetValue()}");
                }
            }
            sr.Close();
        }
        
        public void Load(string filename = "ValuableRepository.txt")
        {
            if (!File.Exists(filename))
                return;

           
            string[] sovssetArray = File.ReadAllLines(filename);

            foreach (string valuableString in sovssetArray)
            {
                string[] frederik = valuableString.Split(";");
                
                switch (frederik[0])
                {
                    case "BOG":
                        Book book = new Book(frederik[1], frederik[2], Convert.ToDouble(frederik[3]));
                        AddValuable(book);
                        break;




                    case "AMULET":
                        Level quality = Level.medium;



                        switch (frederik[2])
                        {
                            case "high":
                                quality = Level.high;
                                break;
                            case "medium":
                                quality = Level.medium;
                                break;
                            case "low":
                                quality = Level.low;
                                break;
                        }

                        Amulet amulet = new Amulet(frederik[1], quality, frederik[3]);
                        AddValuable(amulet);
                        break;





                    case "KURSUS":
                        Course course = new Course(frederik[1], Convert.ToInt32(frederik[2]));
                        AddValuable(course);
                        break;
                }

               
            }

        }

    }
}
