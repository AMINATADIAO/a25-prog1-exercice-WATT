
const int WATT_HEURE = 150;
const double COUT_PAR_WATT = 0.15 / 150;

int nombreHeure;

double coutUtilisation;

Console.WriteLine("Inscrivez le nombre d'heure d'utilisation");
nombreHeure = Convert.ToInt32(Console.ReadLine());
Console.Clear();

coutUtilisation = (WATT_HEURE * COUT_PAR_WATT * nombreHeure);

Console.WriteLine("le cout est egal à:" + coutUtilisation);
