using System;

namespace switch
{
    class Program
    {
        static void Main(string[] args)
        {
            char letra = 'A';

            switch(letra)
            {
                // las comillas simples que encierran a la M, H y R están porque son letras. Si fuesen nros NO van
                case 'M':
                    Console.WriteLine("Tu nombre comienza con M...");
                    // puedo seguir escribiendo dentro del case
                    break;
                case 'H':
                    Console.WriteLine("Tu nombre comienza con H...");
                    // puedo seguir escribiendo dentro del case
                    break;
                case 'R':
                    Console.WriteLine("Tu nombre comienza con R...");
                    // puedo seguir escribiendo dentro del case
                    break;
                default:
                    // no coincide con ningún caso
                    break;
            }
        }
    }
}
