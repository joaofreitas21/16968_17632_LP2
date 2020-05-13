namespace DAO
{
    /*
     MUDAR PARA WFA !!
     */
    public static class Autenticacao
    {
        static string[] User = new string[30];
        static string[] Pw = new string[30];

        static void Inicializa()
        {
           User[0] = "master";
           Pw[0] = "master";
        }
        static public bool Autentication(string user, string pw)
        {
            Inicializa();
            for (int i = 0; i < 30; i++)
            {
                if (User[i] == user && Pw[i] == pw)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
