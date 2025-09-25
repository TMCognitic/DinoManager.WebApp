namespace DinoManager.WebApp.Domain.Entities
{
    public class Dino
    {
        public int Id { get; }
        public string Espece { get; }
        public int Poids { get; }
        public int Taille { get; }
        public Dino(int id, string espece, int poids, int taille)
        {
            Id = id;
            Espece = espece;
            Poids = poids;
            Taille = taille;
        }
    }
}
