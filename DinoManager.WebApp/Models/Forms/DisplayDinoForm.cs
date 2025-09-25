using DinoManager.WebApp.Domain.Entities;

namespace DinoManager.WebApp.Models.Forms
{
    public class DisplayDinoForm
    {
        public int Id { get; }
        public string Espece { get; }
        public int Poids { get; }
        public int Taille { get; }

        public DisplayDinoForm(Dino dino)
        {
            Id = dino.Id;
            Espece = dino.Espece;
            Poids = dino.Poids;
            Taille = dino.Taille;
        }
    }
}
