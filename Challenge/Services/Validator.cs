namespace Services
{
    public static class Validator
    {
        public static bool Verificar(string name)
        {
            char[] nameChar = name.ToCharArray();
            var ResultInicial = false;
            if (nameChar.Length == 2 && nameChar[1] == 46)
            {
                ResultInicial = InicialConPunto(nameChar);
            }
            if (nameChar.Length == 5 && nameChar[1] == 46)
            {
                ResultInicial = InicialesConPuntos(nameChar);
            }
            if (!ResultInicial && nameChar.Length >= 3)
            {
                ResultInicial = ValidarNombre(nameChar);
            }
            return ResultInicial;
        }
        private static bool ValidarNombre(char[] name)
        {
            bool response = true;

            for (int i = 0; i < name.Length; i++)
            {
                if (name[i] == 46 || name[i] == 36)
                {
                    response = false;
                }

            }
            return response;
        }
        private static bool InicialConPunto(char[] name)
        {
            bool response = false;

            for (int i = 0; i < name.Length; i++)
            {
                if (i == 1)
                {
                    if (name[i] == 46)
                    {
                        if (name.Length <= 2)
                        {
                            response = true;
                        }
                    }
                }

            }
            return response;
        }
        private static bool InicialesConPuntos(char[] name)
        {
            bool response = false;

            for (int i = 0; i < name.Length; i++)
            {
                if (i == 4)
                {
                    if (name[i] == 46)
                    {
                        response = true;
                    }
                }

            }
            return response;
        }
    }
}