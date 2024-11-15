using ENT;

namespace DAL
{
    public class PersonaDAL
    {
        public List<Persona> sacarDatosDAL()
        {
            List<Persona> lista = new List<Persona> {
                                                new Persona(1, "Kaleo", "Kauahi", "1988-05-15", "kaleo.jpg", "123 Beach Rd, Lahaina, Maui", 8081234560),
                                                new Persona(2, "Leilani", "Kealoha", "1992-09-12", "leilani.jpg", "456 Hana Hwy, Paia, Maui", 8089876504),
                                                new Persona(3, "Kai", "Manoa", "1985-03-25", "kai.jpg", "789 Ocean Dr, Kihei, Maui", 8085678901),
                                                new Persona(4, "Nani", "Makana", "1990-07-08", "nani.jpg", "321 Sunset Blvd, Wailea, Maui", 8083456789),
                                                new Persona(5, "Ikaika", "Pomaika’i", "1975-11-30", "ikaika.jpg", "159 Mountain View, Kula, Maui", 8089012345),
                                                new Persona(6, "Malia", "Akana", "1995-01-14", "malia.jpg", "432 Palm St, Lahaina, Maui", 8088765432),
                                                new Persona(7, "Kalani", "Koa", "1982-06-18", "kalani.jpg", "876 Bamboo Rd, Kihei, Maui", 8087654321),
                                                new Persona(8, "Lani", "Oka", "1991-10-05", "lani.jpg", "234 Haleakala Hwy, Paia, Maui", 8086543210),
                                                new Persona(9, "Keanu", "Hawaiian", "1994-12-03", "keanu.jpg", "876 Coconut Ave, Kihei, Maui", 8085432109),
                                                new Persona(10, "Pua", "Lehua", "1993-02-21", "pua.jpg", "567 Hana Hwy, Hana, Maui", 8084321098),
                                                new Persona(11, "Lilo", "Nalu", "1986-08-09", "lilo.jpg", "789 Moana Rd, Wailea, Maui", 8083210987),
                                                new Persona(12, "Hokulea", "Kai", "1997-11-02", "hokulea.jpg", "234 Aloha St, Lahaina, Maui", 8082109876),
                                                new Persona(13, "Kaimana", "Aloha", "1989-04-27", "kaimana.jpg", "654 Sunrise Blvd, Paia, Maui", 8081098765),
                                                new Persona(14, "Moana", "Leilani", "1996-07-16", "moana.jpg", "987 Coconut Blvd, Kihei, Maui", 8080987654),
                                                new Persona(15, "Nohea", "Makua", "1983-12-11", "nohea.jpg", "321 Makena Rd, Wailea, Maui", 8089876543)
            };
            return lista;
        }
    }
}
